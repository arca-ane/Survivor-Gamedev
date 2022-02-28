using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public MainLose MainLose;
    public float timeRemaining = 120;
    public bool timerIsRunning = false;
    public Text timeText;
    public Variables Score;
    private void Start()
    {
        // Starts the timer automatically
        Score.value=0;
        timerIsRunning = true;
    }
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                Debug.Log("Your Score is : ");
                Debug.Log(Score.value);
                timeRemaining = 0;
                timerIsRunning = false;
                if(Score.value >=300){
                SceneManager.LoadScene(2);
                }
                else{
                    SceneManager.LoadScene(3);
                }
            }
        }
    }
    void DisplayTime(float timeToDisplay)
    {
        //timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        float milliSeconds = (timeToDisplay % 1) * 100;
        timeText.text = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds,milliSeconds);
    }

}
