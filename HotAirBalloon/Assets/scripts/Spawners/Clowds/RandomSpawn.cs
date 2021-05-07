using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomSpawn : MonoBehaviour
{
    //Массив обектов для спавна
    [SerializeField] public GameObject[] clouds;

    private void Start()
    {
        StartCoroutine(СloudSpawn());
    }
    
    
    private IEnumerator СloudSpawn()
    {
        //  
        while (true)
        {
            yield return new WaitForSeconds(3);
            GameObject cloud = clouds[Random.Range(0, clouds.Length)];
            float rand = UnityEngine.Random.Range(-2f, 3f);
            GameObject obj =  Instantiate(cloud, new Vector3(rand, 5.5f, 0), Quaternion.identity);
            Destroy(obj,6);
        }
    }

        
}
