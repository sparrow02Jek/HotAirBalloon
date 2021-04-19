using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            transform.position = new Vector2(transform.position.x + 1,0);
        }
    }
}
