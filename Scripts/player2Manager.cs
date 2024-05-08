using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2Manager : MonoBehaviour
{
    public static player2Manager Player2Manager { get; private set; }
    public GameObject player; // Prefab of the player to respawn
    public Transform respawnPoint; // Point where the player will respawn
    public int coins;


    void Awake()
    {
        Player2Manager = this;
    }

    public void player2Respawn()
    {
        this.transform.position = respawnPoint.position;

    }



}
