using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericEnemy : DamageableObject
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        base.SetHealthPoints(2);
        PrintGenericEnemyHealthPoints();
                
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PrintGenericEnemyHealthPoints()
    {
        Debug.Log("Enemy health points are: " + base.GetHealthPoints());
    }

    protected override void OnDeath()
    {
        //TODO
        ScoreScript.scoreValue += 1;
        Destroy(this.gameObject);
    }
}
