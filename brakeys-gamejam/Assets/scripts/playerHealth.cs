using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public healthSystem healthS;
    public healthbar healthBar;
    public int maxHealth = 500;


    // Start is called before the first frame update
    void Start()
    {
        healthS = new healthSystem(maxHealth);
        healthBar.setMaxHealth(healthS.healthMax);
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.setHealth(healthS.health);
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
