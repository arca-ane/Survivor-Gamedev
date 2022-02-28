using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyed : MonoBehaviour
{
    public DestroClick destroclick;
    public GameObject bird;
    public Transform t_Destroyed;
    public Transform t_Bird;
    public Bird s_bird;
    //Vector3 b_Movement;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(destroclick.flag)
        {
            t_Bird.position=t_Destroyed.position;
            if(s_bird.b_SpeedValue<350) s_bird.b_SpeedValue+=10;
            else s_bird.b_SpeedValue=350;
            bird.SetActive(true);
            destroclick.flag=false;
        }
    }
}
