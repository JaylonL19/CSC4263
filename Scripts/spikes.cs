using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikes : MonoBehaviour
{
    

private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerManager.PlayerManager.playerRespawn(); // Respawn the player managed by PlayerManager
        }
        else if (collision.gameObject.CompareTag("Player2"))
        {
            player2Manager.Player2Manager.player2Respawn(); // Respawn the player managed by Player2Manager
        }
    }
}
