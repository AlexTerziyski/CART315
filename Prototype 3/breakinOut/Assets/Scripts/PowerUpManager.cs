using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// PowerUpManager.cs
public class PowerUpManager : MonoBehaviour
{
    public static PowerUpManager Instance { get; private set; }

    [SerializeField] private GameObject[] powerUpPrefabs;
    [SerializeField] private float spawnInterval = 10f;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        InvokeRepeating("SpawnRandomPowerUp", 5f, spawnInterval);
    }

    private void SpawnRandomPowerUp()
    {
        if (powerUpPrefabs.Length == 0) return;

        Vector3 randomPosition = new Vector3(Random.Range(-8f, 8f), 5f, 0f);
        int randomIndex = Random.Range(0, powerUpPrefabs.Length);
        Instantiate(powerUpPrefabs[randomIndex], randomPosition, Quaternion.identity);
    }
}