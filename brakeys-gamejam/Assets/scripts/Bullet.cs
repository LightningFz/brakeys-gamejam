using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    [Header("General")]
    public float speed = 20f;
    public int damage = 5;
    public Rigidbody2D rb;

    void Start()
    {
        rb.velocity = transform.up * speed;
    }
    private void Update()
    {
        Kill();
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemies"))
        {
            enemyHealth enemy = collision.GetComponent<enemyHealth>();
            Debug.Log("tookdamage");
            enemy.healthS.Damage(damage);
            Destroy(gameObject);
        }

        if (collision.CompareTag("Platform"))
        {
            Destroy(gameObject);
        }
    }
    public void Kill()
    {
        Destroy(gameObject, 1f);
    }
}
