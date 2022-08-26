using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projecteil : MonoBehaviour
{
    public Vector2 TargetPos;
    private float Speed = 12f; 
    private float DMG = 20; 
    void Start() 
    {
        TargetPos = GameObject.FindGameObjectWithTag("Player").transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, TargetPos, Speed * Time.deltaTime); 
        Destroy(gameObject, 2f);
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.gameObject.CompareTag("Player"))
        {
            print("works");   
            //collision.collider.GetComponent<healthSystem>().Player_TakeDMG(DMG); 
            Destroy(gameObject); 
        }
       
        
    }
}
