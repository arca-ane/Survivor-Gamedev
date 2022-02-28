using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayGame : MonoBehaviour
{
    public void PlayGameSurvivor()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void Guide()
    {
        SceneManager.LoadScene(6);
    }

    public void BackMAin()
    {
        SceneManager.LoadScene(0);
        
    }

}