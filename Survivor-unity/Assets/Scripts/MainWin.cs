using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainWin : MonoBehaviour
{
    public void Next(){
        SceneManager.LoadScene(4);
    }
    public void Quit(){ 
        Debug.Log("QUIT!!!!");
        Application.Quit();
    }
}

