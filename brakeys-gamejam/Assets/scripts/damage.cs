using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour
{
    public int DamageAmount = 10;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _Damage(collision);
        }
        else if (collision.CompareTag("Helper"))
        {
            _DamageHelper(collision);
        }
    }

    void _Damage(Collider2D player)
    {
        playerHealth health = player.GetComponentInChildren<playerHealth>();
        health.healthS.Damage(DamageAmount);
    }
    void _DamageHelper(Collider2D helper)
    {
        helperHealth health = helper.GetComponentInChildren<helperHealth>();
        health.healthS.Damage(DamageAmount);
    }
}
