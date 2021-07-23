using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : DamageableObject
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        base.setHealthPoints(3);
        printHealthPoints();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void printHealthPoints()
    {
        Debug.Log("Player health points are: " + base.getHealthPoints());
    }
}
