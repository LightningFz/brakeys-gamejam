using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float HP; 

    private float Speed = 10f;
    public Transform Target; 
    private float MinDis = 3f; 

    public GameObject Projectile; 
    private float TimeBetweenShots =3f; 
    private float TimeToFire;

    // Start is called before the first frame update
    void Start()
    {
        HP = 100f; 
    }

    // Update is called once per frame
    void Update()
    {   if(Vector2.Distance(transform.position, Target.position) < MinDis)
        {
         transform.position = Vector2.MoveTowards(transform.position, Target.position, -Speed * Time.deltaTime); 
        }
        if (Time.time > TimeToFire) 
        {
            Instantiate(Projectile, gameObject.transform.position, Quaternion.identity); 
            TimeToFire = Time.time + TimeBetweenShots; 
        }
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
