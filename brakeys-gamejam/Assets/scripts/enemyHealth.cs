using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{
    public healthSystem healthS;
    public healthbar healthBar;
    public int maxHealth = 50;

    public RectTransform healthBarRect;

    private Quaternion rotation;
    private Vector3 position;
    /*void Awake()
    {
        //rotation = transform.rotation;
        //position = transform.parent.position - transform.position;
    }*/
    // Start is called before the first frame update
    void Start()
    {
        healthS = new healthSystem(maxHealth);
        healthBar.setMaxHealth(healthS.healthMax);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.rotation = rotation;
        //transform.position = transform.parent.position - position;
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
