using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeagullBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject Seagull; // Seagull - это чайка !
    [SerializeField] private GameObject _appliedDamage;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x <= 0.5f)
        {
            Seagull.transform.Translate(-2 * Time.deltaTime, 0, 0);
        }
        if(transform.position.x <= -3)
        {
            print("Stop!");
            Destroy(Seagull);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            print("Player!");
            Seagull.transform.Translate(-2 * Time.deltaTime, 0, 0);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        _appliedDamage.SetActive(true);
        print("player");
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        _appliedDamage.SetActive(false);
    }
}
