using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : DamageableObject
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        base.SetHealthPoints(3);
        PrintHealthPoints();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PrintHealthPoints()
    {
        Debug.Log("Player health points are: " + base.GetHealthPoints());
    }

    protected override void OnDeath()
    {

        Destroy(this.gameObject);
        
    }
}
