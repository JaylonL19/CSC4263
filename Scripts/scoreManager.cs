using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scoreManager : MonoBehaviour
{
    public static scoreManager instance;

    public TextMeshProUGUI p1scoreText;
    public TextMeshProUGUI p2scoreText;

    int p1score = 0;
    int p2score = 0;

    void Start()
    {
        p1scoreText.text = "P1 coins: " + p1score.ToString();
        p2scoreText.text = "P2 coins: " + p2score.ToString();
    }

    // Update is called once per frame
   public void Awake()
    {
        instance = this;
    }

    public void p1AddPoints()
    {
        p1score += 10;
        p1scoreText.text = "COINS: " + p1score.ToString();
    }

    public void p2AddPoints()
    {
        p2score += 10;
        p2scoreText.text = "COINS: " + p2score.ToString();
    }
}
