using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D RB;
    public Transform Traget;
    private float Speed = 12f;
    private float MinDis = 3f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, Traget.position) > MinDis)
        {
            transform.position = Vector2.MoveTowards(transform.position, Traget.position, Speed * Time.deltaTime);
        }
    }
}
