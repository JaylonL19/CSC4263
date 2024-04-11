using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats playerStats;

    public GameObject player1;
    public float health;
    public float maxHealth;
    public int coins;


    void Awake()
    {
        playerStats = this;
    }

    void Start()
    {
        health = maxHealth;
    }

    public void DealDamage(float damage)
    {
        health -= damage;
        CheckDeath();
    }

    void CheckDeath() 
    {
        if (health <= 0)
        {
            Destroy(player1);
        }
    }
}


