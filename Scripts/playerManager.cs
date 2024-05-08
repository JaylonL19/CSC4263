using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerManager : MonoBehaviour
{
     public static playerManager PlayerManager { get; private set; }
    public GameObject player; // Prefab of the player to respawn
    public Transform respawnPoint; // Point where the player will respawn
    public int coins;

    // Update is called once per frame
    void Awake()
    {
        PlayerManager = this;
    }

    public void playerRespawn()
    {
        this.transform.position = respawnPoint.position;
    }


}
