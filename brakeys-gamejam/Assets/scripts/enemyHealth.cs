using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{
    public healthSystem healthS;
    public healthbar healthBar;
    public int maxHealth = 50;

    // Start is called before the first frame update
    void Start()
    {
        healthS = new healthSystem(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
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
