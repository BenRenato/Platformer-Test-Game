using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    public Animator animatior;

    //Attack starting points
    public Transform attackPointForward;
    public Transform attackPointOverhead;
    
    //Individual ranges for each collider
    public float attackRangeForward = 0.5f;
    public float attackRangeOverhead = 0.5f;

    GenericEnemy GenericEnemyScriptCache;

    //Enemies layer
    public LayerMask enemyLayers;

    private void Awake()
    {
        GenericEnemyScriptCache = GetComponent<GenericEnemy>();
    }
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.F))
        {
            BasicAttack();
        }

        //StrongAttack() -> BuildHitEnemyList() -> ReduceHealthPoints(2).

    }

    void BasicAttack()
    {
        Debug.Log("Triggering attack");

        animatior.SetTrigger("Basic Attack");

        var hitEnemiesList = BuildHitEnemyList();

        //Return early if we hit nothing
        if (hitEnemiesList.Count == 0)
        {
            Debug.Log("Hit nothing.");
            return;
        }

        //Iterate over the list
        foreach (Collider2D enemy in hitEnemiesList)
        {
            Debug.Log("Enemy hit.");

            //This might be less expensive than SendMessageUpward(), need to profile.
            //TODO PROFILE COMPARSION
            enemy.gameObject.GetComponent<GenericEnemy>().ReduceHealthPoints(1); 

            //enemy.SendMessageUpwards("ReduceHealthPoints", 1);
        }
    }

    List<Collider2D> BuildHitEnemyList()
    {
        //Get all colliders that are hit by the forward swing
        List<Collider2D> hitEnemies = new List<Collider2D>(Physics2D.OverlapCircleAll(attackPointForward.position, attackRangeForward, enemyLayers));

        //Add another list of overhead colliders that are hit
        hitEnemies.AddRange(Physics2D.OverlapCircleAll(attackPointOverhead.position, attackRangeOverhead, enemyLayers));

        return hitEnemies;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(attackPointForward.position, attackRangeForward);
        Gizmos.DrawWireSphere(attackPointOverhead.position, attackRangeOverhead);
    }



}
