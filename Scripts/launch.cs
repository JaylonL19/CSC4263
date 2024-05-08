using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launch : MonoBehaviour
{

    public GameObject dispenser;
    public GameObject bombPrefab; // Prefab of the bomb to be launched
    public GameObject target;
    public float spawnInterval = 2f; // Interval between bomb spawns
    public float speed = 10f;

    private float dispenserX;
    private float targetX;

    void Start()
    {
        dispenser = GameObject.FindGameObjectWithTag("Despenser"); // Correcting typo in tag name
        StartCoroutine(SpawnBombs());
    }

    IEnumerator SpawnBombs()
    {
        while (true)
        {
            // Instantiate bomb at dispenser position
            GameObject newBomb = Instantiate(bombPrefab, dispenser.transform.position, Quaternion.identity);
            Rigidbody2D bombRigidbody = newBomb.GetComponent<Rigidbody2D>();
            // Set the velocity of the bomb to fall downward
            bombRigidbody.velocity = Vector2.down * speed;
            // Destroy the bomb after a delay (optional)
            Destroy(newBomb, 5f);

            yield return new WaitForSeconds(spawnInterval);
        }
    }
}