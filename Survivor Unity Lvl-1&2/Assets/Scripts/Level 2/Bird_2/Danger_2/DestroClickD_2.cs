using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroClickD_2 : MonoBehaviour
{

  public GameObject Bird;
  public Transform t_bird;
  public Timer time;
  public bool flag =false;
  void Update() 
  {  
    if (Input.GetMouseButtonDown(0)) 
    {  
      Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  
      RaycastHit hit;  
      if (Physics.Raycast(ray, out hit)) 
      {  
        //Select stage    
        if (hit.transform == t_bird) 
        {  
            Bird.SetActive(false);
            time.timeRemaining-=5;
            flag=true;
        }  
      }  
    }  
  }   
}
