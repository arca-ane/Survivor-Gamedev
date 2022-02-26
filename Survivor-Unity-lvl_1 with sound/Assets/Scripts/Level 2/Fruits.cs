using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits : MonoBehaviour
{
    
    public Transform refrence;
    public Transform t_bird;
    public Transform[] t_Fruit;
    public Bird_2 bird;
    public GameObject[] g_Fruit;
    public Variables f_score;
    // public Transform t_pos;
    public bool Iscollided=false;
    public bool Isshot=false;
    public int rf; //random to select fruit
    public float rdrop; //random to drop fruit

    public float f_SpeedValue=335f;
    float f_Speed;
    Vector3 f_Movement;

    public bool trigger=false;

    void Start()
    {
        f_Speed=f_SpeedValue*Time.deltaTime;
        g_Fruit[0].SetActive(false);
        g_Fruit[1].SetActive(false);
        t_Fruit[0].position=refrence.position;
        t_Fruit[1].position=refrence.position;
        rf=randomGenerate();
        rdrop=randomdrop();
    }

    // Update is called once per frame
    void Update()
    {
        if(bird.rightFrame || bird.leftFrame)
        {
            rdrop=randomdrop();
            if(Mathf.Approximately(rdrop,t_bird.position.x))
            {
                trigger=true;
            }
        }
        
        
        
        if(trigger)
        {
            rf=randomGenerate();
            g_Fruit[rf].SetActive(true);
            t_Fruit[rf].position=t_bird.position;
            trigger=false;
        }
        f_Movement.Set(0,-f_Speed,0);
        t_Fruit[rf].position+=f_Movement;
        // t_pos=t_Fruit[rf];
        if(Iscollided)
        {
            g_Fruit[rf].SetActive(false);
            t_Fruit[rf].position=refrence.position;
            Iscollided=false;
        }
        if(Isshot)
        {
            g_Fruit[rf].SetActive(false);
            t_Fruit[rf].position=refrence.position;
            f_score.value+=10;
            Isshot=false;
        }
    }

    int randomGenerate()
    {
        int rand;
        rand=Random.Range(0,2);
        return rand;
    }

    float randomdrop()
    {
        float rand;
        rand=Random.Range(0f,200f);
        return rand;
    }
}
