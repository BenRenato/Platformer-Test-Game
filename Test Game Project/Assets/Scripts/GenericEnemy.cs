using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericEnemy : DamageableObject
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        base.setHealthPoints(2);
        printGenericEnemyHealthPoints();
                
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void printGenericEnemyHealthPoints()
    {
        Debug.Log("Enemy health points are: " + base.getHealthPoints());
    }
}
