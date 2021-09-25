using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _spawnObject;
    [SerializeField] private float _spawnInterval;

    private void Start()
    {
        InvokeRepeating("SpawnObject", 0, _spawnInterval);
    }

    private void SpawnObject()
    {
        Instantiate(_spawnObject, transform.position, Quaternion.identity);
    }
}
