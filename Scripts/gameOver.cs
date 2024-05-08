using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(LoadGameOverAfterTime(150)); // 150 seconds = 2 minutes and 30 seconds
    }

    IEnumerator LoadGameOverAfterTime(float seconds)
    {
        yield return new WaitForSeconds(seconds); // Wait for the specified amount of seconds
        SceneManager.LoadScene("gameOverScene"); // Load the game over scene
    }
    public void LoadLevelScene()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void LoadMenuScene()
    {
        SceneManager.LoadScene("mainMenu");
    }
}
