using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackHitboxCheck : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.isTrigger != true && collision.CompareTag("Enemy"))
        {
            Debug.Log("Found enemy");
            collision.SendMessageUpwards("ReduceHealthPoints", 1);
        }
    }

}
