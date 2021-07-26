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


    private bool isAttacking = false;
    private float attackTimer = 0;
    private float attackCooldown = 0f;
    

    public Collider2D forwardSwingHitbox;
    public Collider2D overheadSwingHitbox;

    private void Awake()
    {
        forwardSwingHitbox = forwardSwingHitbox.GetComponent<Collider2D>();
        overheadSwingHitbox = overheadSwingHitbox.GetComponent<Collider2D>();

        forwardSwingHitbox.enabled = false;
        overheadSwingHitbox.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.F))
        {
            BasicAttack();
        }

        
        if (isAttacking)
        {
            if (attackTimer > 0)
            {
                attackTimer = Time.deltaTime;
            }
            else
            {
                isAttacking = false;
            }
        }
        

    }

    void BasicAttack()
    {
        Debug.Log("Triggering attack");
        
        isAttacking = true;
        attackTimer = attackCooldown;
        
        animatior.SetTrigger("Basic Attack");
        forwardSwingHitbox.enabled = true;
        overheadSwingHitbox.enabled = true;

    }



}
