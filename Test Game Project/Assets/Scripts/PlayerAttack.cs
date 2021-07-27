using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    public Animator animatior;


    public Transform attackPointForward;
    public Transform attackPointOverhead;
    public float attackRangeForward = 0.5f;
    public float attackRangeOverhead = 0.5f;
    public LayerMask enemyLayers;

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.F))
        {
            BasicAttack();
        }

        

    }

    void BasicAttack()
    {
        Debug.Log("Triggering attack");

        animatior.SetTrigger("Basic Attack");

        List<Collider2D> hitEnemies = new List<Collider2D>(Physics2D.OverlapCircleAll(attackPointForward.position, attackRangeForward, enemyLayers));

        hitEnemies.AddRange(Physics2D.OverlapCircleAll(attackPointOverhead.position, attackRangeOverhead, enemyLayers));

        foreach (Collider2D enemy in hitEnemies)
        {
            Debug.Log("Enemy hit.");
            enemy.SendMessageUpwards("ReduceHealthPoints", 1);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(attackPointForward.position, attackRangeForward);
        Gizmos.DrawWireSphere(attackPointOverhead.position, attackRangeOverhead);
    }



}
