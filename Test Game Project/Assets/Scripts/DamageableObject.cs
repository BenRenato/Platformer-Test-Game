using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// We just want all child classes to be able to take damage, and have an initial HP value.
// Maybe better to implement as an interface, but behaviour is the same, so interface the other methods
// That have custom implementations.
public class DamageableObject : MonoBehaviour
{

    protected int healthPoints;
    
    // Protected virtual start so we can call + override in child classes
    protected virtual void Start()
    {
        this.healthPoints = 1;
        Debug.Log("Set HP to 1, vis DamageableObject Start()");
    }

    
    protected void setHealthPoints(int startingHealth)
    {
        this.healthPoints = startingHealth;
    }

    protected int getHealthPoints()
    {
        return this.healthPoints;
    }

    protected void reduceHealthPoints(int damageInflicted)
    {
        setHealthPoints(getHealthPoints() - damageInflicted);
        //Check if object is "dead".
        checkIfHealthZero();
    }

    protected void checkIfHealthZero()
    {
        if (getHealthPoints() <= 0)
        {
            Destroy(this.gameObject);
        }
    }

}
