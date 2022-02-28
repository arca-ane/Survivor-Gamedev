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
    public bool Iscollided=false;
    public bool Isshot=false;
    bool Isdropped=false;
    public int rf; //random to select fruit
    public int rdrop; //random to drop fruit

    public float f_SpeedValue=335f;
    float f_Speed;
    Vector3 f_Movement;
    Vector3 randomPosition;

    bool trigger=false;

    void Start()
    {
        f_Speed=f_SpeedValue*Time.deltaTime;
        for(int i=0;i<6;i++)
        {
            g_Fruit[i].SetActive(false);
            t_Fruit[i].position=refrence.position;
        }
        // g_Fruit[0].SetActive(false);
        // g_Fruit[1].SetActive(false);
        // g_Fruit[2].SetActive(false);
        // t_Fruit[0].position=refrence.position;
        // t_Fruit[1].position=refrence.position;
        // t_Fruit[2].position=refrence.position;
        rf=randomGenerate();
        rdrop=randomdrop();
    }

    // Update is called once per frame
    void Update()
    {
        
        rdrop=randomdrop();
        if(rdrop==2 && !Isdropped)
        {
            trigger=true;
            Isdropped=true;
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
            Isdropped=false;
        }
        if(Isshot)
        {
            g_Fruit[rf].SetActive(false);
            t_Fruit[rf].position=refrence.position;
            f_score.value+=10;
            Isshot=false;
            Isdropped=false;
        }
    }

    int randomGenerate()
    {
        int rand;
        rand=Random.Range(0,6);
        return rand;
    }

    int randomdrop()
    {
        int rand;
        rand=Random.Range(0,5);
        return rand;
    }
}
