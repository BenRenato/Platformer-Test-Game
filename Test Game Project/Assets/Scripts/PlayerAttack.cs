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

        /* Hitbox detection, probably need to change this from a raycast to use the two overhead/swing colliders.
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackOrigin.position, attackRange, enemyLayers);

         Damage calculation iterable can probably be kept.
        foreach (Collider2D enemy in hitEnemies)
        {
            Debug.Log("We hit " + enemy.name);

        }
        */
    }
}
