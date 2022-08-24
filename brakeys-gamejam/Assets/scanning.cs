using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using a = AstarPath;

public class scanning : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AstarPath.active.Scan();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
