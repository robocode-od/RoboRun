using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _spawnObjects;
    [SerializeField] private float _spawnInterval;



    private void Start()
    { 
        InvokeRepeating("SpawnObject", 0, _spawnInterval);
    }

    private void SpawnObject()
    {
        int spawnObjectIndex = Random.Range(0, _spawnObjects.Length);
        Instantiate(_spawnObjects[spawnObjectIndex], transform.position, Quaternion.identity);
    }
}
