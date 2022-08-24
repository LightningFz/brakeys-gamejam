using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float HP; 
    
    // Start is called before the first frame update
    void Start()
    {
        HP = 100f; 
    }

    // Update is called once per frame
    void Update()
    {
        if (HP == 0 ) 
        {
            Destroy(gameObject); 
        }
    }
    public void TakeDMG(float BulletDmg) 
    {
        HP -= BulletDmg;
        print(HP); 
    }
}
