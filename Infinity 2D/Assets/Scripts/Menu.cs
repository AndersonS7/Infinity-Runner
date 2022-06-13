using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
    private MusicControl musicControl;

    void Update()
    {
        musicControl = FindObjectOfType<MusicControl>();

        if (musicControl != null)
        {
            Destroy(musicControl.gameObject);
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
