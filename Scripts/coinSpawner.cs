using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinSpawner : MonoBehaviour
{
    public GameObject coinPrefab; // Prefab of the coin to spawn
    public List<Transform> coinDispensers; // List of all coin dispensers

    // Start is called before the first frame update
    void Start()
    {
        PopulateCoinDispensers();
    }



    void PopulateCoinDispensers()
    {
        coinDispensers.Clear(); // Clear the list to avoid duplicates

        // Find all coin dispenser objects in the scene and add their transforms to the list
        GameObject[] dispenserObjects = GameObject.FindGameObjectsWithTag("dispenser");
        foreach (GameObject dispenserObject in dispenserObjects)
        {
            coinDispensers.Add(dispenserObject.transform);
        }
    }

    // Method to spawn a coin on a random dispenser
    public void SpawnCoinOnRandomDispenser()
    {
        if (coinDispensers.Count > 0)
        {
            // Select a random dispenser from the list
            int randomIndex = Random.Range(0, coinDispensers.Count);
            Transform randomDispenser = coinDispensers[randomIndex];

            // Spawn a coin at the position of the selected dispenser
            Instantiate(coinPrefab, randomDispenser.position, Quaternion.identity);

        }
    }
}
