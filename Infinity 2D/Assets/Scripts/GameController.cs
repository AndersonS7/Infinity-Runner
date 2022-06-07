using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Text scoreTxt;
    public GameObject gameOverPanel;
    public static GameController instance;
    public float score;
    public float timeScore;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        instance = this;
        Time.timeScale = 1;
    }

    void Update()
    {
        timeScore += Time.deltaTime;

        if (timeScore >= 2)
        {
            score++;
            scoreTxt.text = score.ToString();
            timeScore = 0;
        }
    }

    public void ShowGameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0; //controla a velocidade do jogo 
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }
}
