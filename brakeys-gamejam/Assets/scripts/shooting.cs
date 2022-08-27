using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class shooting : MonoBehaviour
{

    public GameObject bulletPrefab; 
    public Transform firepoint;
    public float bulletForce = 20f;
    public float CameraShakePower;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        //CinemachineShake.Instance.ShakeCamera(CameraShakePower, 0.1f);
        GameObject bullet = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firepoint.up * bulletForce, ForceMode2D.Impulse);
        
    }
}
