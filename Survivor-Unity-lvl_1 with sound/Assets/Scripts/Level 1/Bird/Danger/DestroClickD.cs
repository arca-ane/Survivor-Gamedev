using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroClickD : MonoBehaviour

{

  public GameObject Bird;
  public Timer time;
  public bool flag =false;
  AudioSource m_shootingSound;
  void Start()
  {
    m_shootingSound = GetComponent<AudioSource>();
  }
  void Update() 
  {  
    if (Input.GetMouseButtonDown(0)) 
    {  


      Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  
      RaycastHit hit;  
      if (Physics.Raycast(ray, out hit)) 
      {  
        //Select stage    
        if (hit.transform.name == "BirdDanger") 
        {
            m_shootingSound.Play();  
            Bird.SetActive(false);
            time.timeRemaining-=5;
            flag=true;
        }  
      }  
    }  
  }   
}
