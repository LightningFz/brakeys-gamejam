using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{
    public healthSystem healthS;
    public healthbar healthBar;
    public GameObject healthBarGameObject;
    public int maxHealth = 50;

    public RectTransform healthBarRect;

   
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
            Destroy(healthBarGameObject);
            Destroy(gameObject);
        }
    }
}
