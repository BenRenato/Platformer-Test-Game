using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
Not sure if abstract class is better than having multiple interfaces, but having an abstract class
seemed like the best ideas as I could implement functionality for shared methods that are 100% identical
e.g get/set/reduce etc, then add custom implementations via abstract methods that could add certain class
specific functionality.
**/
public abstract class DamageableObject : MonoBehaviour
{

    protected int healthPoints;
    
    // Protected virtual start so we can call + override in child classes
    protected virtual void Start()
    {
        this.healthPoints = 1;
        Debug.Log("Set HP to 1, vis DamageableObject Start()");
    }

    
    protected void SetHealthPoints(int startingHealth)
    {
        this.healthPoints = startingHealth;
    }

    protected int GetHealthPoints()
    {
        return this.healthPoints;
    }

    protected void ReduceHealthPoints(int damageInflicted)
    {
        SetHealthPoints(GetHealthPoints() - damageInflicted);
        Debug.Log("Current HP: " + GetHealthPoints());
        //Check if object is "dead".
        CheckIfHealthZero();
    }

    protected void CheckIfHealthZero()
    {
        if (GetHealthPoints() <= 0)
        {
            OnDeath();
        }
    }

    protected abstract void OnDeath();

}
