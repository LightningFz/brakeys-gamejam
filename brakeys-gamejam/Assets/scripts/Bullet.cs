using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    private Rigidbody2D rb; 
    private float BulletForce = 20f; 

    private float BulletDMG =20f; 
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.forward * BulletForce); 
        Destroy(gameObject, 1f); 
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.collider.GetComponent<Enemy>().TakeDMG(BulletDMG); 
            Destroy(gameObject); 
        }
        
    }

}

