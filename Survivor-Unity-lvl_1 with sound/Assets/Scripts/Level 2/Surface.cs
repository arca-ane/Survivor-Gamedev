using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Surface : MonoBehaviour
{
    public Fruits fr;
    public Transform[] t_fruit;

//    void update() 
//    {
//        t_fruit=fr.t_pos;
//    }
   void OnTriggerEnter (Collider other)
   {
       if(other.transform==t_fruit[fr.rf])
        {
            fr.Iscollided=true;
        }
    }
}
