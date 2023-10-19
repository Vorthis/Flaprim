using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Punktacja : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject GameOverScreean;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + 1;
        scoreText.text = playerScore.ToString();
        
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        GameOverScreean.SetActive(true);
    }
}
   