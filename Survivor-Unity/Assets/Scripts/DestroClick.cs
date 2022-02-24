using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroClick : MonoBehaviour
{

  public GameObject Bird;
  public Variables p_score;
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
        if (hit.transform.name == "Bird") 
        {  
            Bird.SetActive(false);
            p_score.value+=10;
            flag=true;
        }  
      }  
    }  
  }   
}
