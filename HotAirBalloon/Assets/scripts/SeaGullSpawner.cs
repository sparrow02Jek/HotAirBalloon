using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class SeaGullSpawner: MonoBehaviour
{
    [SerializeField] private GameObject SeaGull;
    
    void Start()
    {
        StartCoroutine(SeagullSpawner());
    }

    void Update()
    {
        
    }

    private IEnumerator SeagullSpawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            float rand = Random.Range(1, 3);
            if (rand == 1)
            {
                print(rand);
                GameObject obj = Instantiate(SeaGull, new Vector3(-4.05f, 0, 0),Quaternion.Euler(0,180,0 ));
                Destroy(obj, 3);
            }
            else if(rand == 2)
            {
                print(rand);
                GameObject obj = Instantiate(SeaGull, new Vector3(3.89f, 5.5f, 0), Quaternion.identity);
                Destroy(obj, 3);
            }
            
            print("Seagull Spawn");
        }
    }
}
