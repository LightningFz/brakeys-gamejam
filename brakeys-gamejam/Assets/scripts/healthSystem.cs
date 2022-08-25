using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthSystem : MonoBehaviour
{
    public float Player_HP; 
    // Start is called before the first frame update
    void Start()
    {
        Player_HP = 100f; 
    }

    // Update is called once per frame
    public void Player_TakeDMG(float ProjectileDMG)
    {
        Player_HP -= ProjectileDMG; 
        print(Player_HP); 
    }
}
