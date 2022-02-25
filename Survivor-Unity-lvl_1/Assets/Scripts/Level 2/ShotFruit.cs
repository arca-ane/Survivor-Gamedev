using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotFruit : MonoBehaviour
{
    public Timer time;
    public Fruits fru;
    void Update() 
    {  
        if (Input.GetMouseButtonDown(0)) 
        {  
           Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  
           RaycastHit hit;  
           if (Physics.Raycast(ray, out hit)) 
           {  
                //Select stage    
                if (hit.transform.name == "Orange") 
                {  
                    fru.Isshot=true;
                }  
            }  
        }  
    }
}
