using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class CoinCloudSpawner : MonoBehaviour
{
    [SerializeField] private GameObject coinClowds;
    [Range(0,100)] [SerializeField] private int chance;
    [SerializeField] private float timeOffset;
    
    private int _randomInt;
    
    private float _currentTime;

    private void Start()
    {
        _currentTime = timeOffset;
    }

    private void Update()
    {
        if(_currentTime < 0)
        {
            timeOffset = Random.Range(1, 5);
            _currentTime = timeOffset;
            
            SpawnGoldCloud();
        }

        _currentTime -= Time.deltaTime;
    }

    private void SpawnGoldCloud()
    {
        int num = Random.Range(0,100);
        if (num <= chance)
        {
            float rand = UnityEngine.Random.Range(-3f, 4f);
            GameObject obj = Instantiate(coinClowds, new Vector3(rand, 5, 0), Quaternion.identity);
            Destroy(obj,6);
        }
    }
}
