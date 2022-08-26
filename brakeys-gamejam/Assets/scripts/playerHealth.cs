using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public healthSystem healthS;
    public int maxHealth = 500;


    // Start is called before the first frame update
    void Start()
    {
        healthS = new healthSystem(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(healthS.health);
        Die();
    }
    public void Die()
    {
        if (healthS.health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
