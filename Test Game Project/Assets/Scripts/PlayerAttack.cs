using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    public Animator animatior;

    /* Attack specific variables
    public Transform attackOrigin;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    */

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

        /* Hitbox detection
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackOrigin.position, attackRange, enemyLayers);

         Damage calculation iterable TODO: Continue from tutorial video @ 9:55
        foreach (Collider2D enemy in hitEnemies)
        {
            Debug.Log("We hit " + enemy.name);

        }
        */
    }
}
