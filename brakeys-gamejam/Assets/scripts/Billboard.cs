using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    public Transform enemy;
    void Awake()
    {
        Vector3 enemyPos = new Vector3(enemy.transform.position.x, enemy.position.y + 1, 0f);
        gameObject.transform.position = enemyPos;
    }
    void LateUpdate()
    {
        Vector3 enemyPos = new Vector3(enemy.transform.position.x, enemy.position.y + 1, 0f);
        gameObject.transform.position = enemyPos;
    }
}
