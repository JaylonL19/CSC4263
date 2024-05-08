using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    public enum PickupObject
    {
        COIN
        // Add more pickup types here if needed
    }

    public PickupObject pickupType;
    public int pickQuantity;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Player2"))
        {
            if (pickupType == PickupObject.COIN)
            {
                UpdateCoins(other);
                DisableCoin();
                RequestNewCoinSpawn();
            }
        }
    }

    public void UpdateCoins(Collider2D player)
    {
        if (player.CompareTag("Player"))
        {
            playerManager.PlayerManager.coins += pickQuantity;
            scoreManager.instance.p1AddPoints();
            Debug.Log("Player 1 Coins: " + playerManager.PlayerManager.coins);
        }
        else if (player.CompareTag("Player2"))
        {
            player2Manager.Player2Manager.coins += pickQuantity;
            scoreManager.instance.p2AddPoints();
            Debug.Log("Player 2 Coins: " + player2Manager.Player2Manager.coins);
        }
    }

   public void DisableCoin()
    {
        // Disable the collider and GameObject to avoid further interaction
        GetComponent<Collider2D>().enabled = false;
        gameObject.SetActive(false);
    }

    public void RequestNewCoinSpawn()
    {
        spawnCoins coinSpawner = FindObjectOfType<spawnCoins>();
        if (coinSpawner != null)
        {
            coinSpawner.SpawnCoinOnRandomDispenser();
        }
        else
        {
            Debug.LogError("spawnCoins script not found in the scene!");
        }
    }
}
