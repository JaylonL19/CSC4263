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

    void OnTriggerEnter2D(Collider2D other)
    {
        print(other);
        if (other.CompareTag("Player"))
        {
            if (pickupType == PickupObject.COIN)
            {
                PlayerStats.playerStats.coins += pickQuantity;
                Debug.Log("Coins: " + PlayerStats.playerStats.coins);
                Destroy(gameObject); // Destroy the coin object after pickup
            }
        }
    }
}
