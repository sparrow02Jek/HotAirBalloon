using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefab_move : MonoBehaviour
{
    public GameObject obj;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(0,-2 * Time.deltaTime,0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "enemy")
        {
            Destroy(gameObject);
            Debug.Log("diaw");
        }
    }
    
}
