using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObsSpawner : MonoBehaviour
{
    public GameObject obsPrefab;
    public float spawnInterval = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnObs", 1f, spawnInterval);

    }
    void SpawnObs()
    {
        Vector3 spawnPos = new Vector3(2.50F, -4.0f, 0);
        Instantiate(obsPrefab, spawnPos, Quaternion.identity);
    }

}
