using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotFruit : MonoBehaviour
{
    public timerlvl2 time;
    public Fruits fru;
    public Transform[] t_frux;
    AudioSource m_shootingSound;

    void start()
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
                if (hit.transform == t_frux[fru.rf]) 
                {  
                    //m_shootingSound.Play();
                    fru.Isshot=true;
                }  
            }  
        }  
    }
}
