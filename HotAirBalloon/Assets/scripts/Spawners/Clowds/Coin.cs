using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    //public GameObject сoins;
   
    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.collider.tag != "Player"){
            Destroy(gameObject);
        }
    }
    private void OnCollisionStay2D(Collision2D collision2)
    {
        if( collision2.gameObject.tag == "enemy" ){
            
            Destroy(gameObject);
        }
    }
}

