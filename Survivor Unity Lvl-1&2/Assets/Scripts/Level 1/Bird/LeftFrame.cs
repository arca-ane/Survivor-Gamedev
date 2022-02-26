using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftFrame : MonoBehaviour
{
    public Bird bird;
    public Transform t_Bird;

   void OnTriggerEnter (Collider other)
   {
       if(other.transform==t_Bird)
        {
            bird.leftFrame=true;
        }
    }
   
}
