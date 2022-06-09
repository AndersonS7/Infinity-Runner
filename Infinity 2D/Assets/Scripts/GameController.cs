using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //UI 
    public Text scoreTxt;
    public Text scoreGameOver;
    public Text scoreRecordGameOver;

    //------------------
    public GameObject gameOverPanel;
    public static GameController instance;

    public int currentScore;
    public float timeScore;
    public bool paused;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        currentScore = 0;
        Time.timeScale = 1;
    }

    void Update()
    {
        ShowScoreUI();
        ScoreControl();
    }

    public void ShowGameOver()
    {
        scoreGameOver.text = currentScore.ToString();
        scoreRecordGameOver.text = PlayerPrefs.GetInt("score").ToString();

        paused = true;
        gameOverPanel.SetActive(true);
        Time.timeScale = 0; //controla a velocidade do jogo 
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    private void ShowScoreUI()
    {
        timeScore += Time.deltaTime;

        if (timeScore >= 2)
        {
            currentScore++;
            scoreTxt.text = currentScore.ToString();
            timeScore = 0;
        }
    }

    private void ScoreControl()
    {
        if (PlayerPrefs.GetInt("score") < currentScore)
        {
            PlayerPrefs.SetInt("score", currentScore);
            PlayerPrefs.Save();
        }
    }
}
