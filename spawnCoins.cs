using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnCoins : MonoBehaviour
{
    public GameObject coinPrefab; // Reference to the coin prefab
    public Transform[] spawnPoints; // Array of spawn points
    public float spawnInterval = 5.0f; // Interval in seconds between spawns
    public float spawnDuration = 15 * 60.0f; // Duration in seconds (15 minutes)

    private Coroutine spawnCoroutine; // Reference to the spawn coroutine

    void Start()
    {
        // Start spawning coins
        spawnCoroutine = StartCoroutine(SpawnCoins());
    }

    IEnumerator SpawnCoins()
    {
        float elapsedTime = 0.0f;

        // Continue spawning coins for the specified duration
        while (elapsedTime < spawnDuration)
        {
            // Spawn a coin at a random spawn point
            Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
            Instantiate(coinPrefab, spawnPoint.position, Quaternion.identity);

            // Wait for the spawn interval before spawning the next coin
            yield return new WaitForSeconds(spawnInterval);

            // Increment the elapsed time
            elapsedTime += spawnInterval;
        }
    }
}
