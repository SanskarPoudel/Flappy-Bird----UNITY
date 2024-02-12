using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{

    public int playerScore;

    public Text scoreText;

    public GameObject gameOverScreen;

    public bool gameStarted = false;

    public GameObject gameStartScreen;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {

        playerScore += scoreToAdd;

        scoreText.text = playerScore.ToString();


    }


    public void restartGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        gameStarted = false;

    }


    public void startGame()
    {
        gameStartScreen.SetActive(false);
        gameStarted = true;
    }





}
