using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyedD : MonoBehaviour
{
    public DestroClickD destroclick;
    public GameObject bird;
    public Transform t_Destroyed;
    public Transform t_Bird;
    public Bird s_bird;
    public GameObject b_Danger;
    bool inst=false;
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
            inst=true;
            //Instantiate(b_Danger);
            destroclick.flag=false;
        }

        if(inst)
        {
            Instantiate(b_Danger);
            inst=false;
        }
    }
}
