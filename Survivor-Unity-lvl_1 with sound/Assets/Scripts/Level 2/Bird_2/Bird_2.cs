using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_2 : MonoBehaviour
{
    Rigidbody b_Rigidbody;
    
    public Transform bird;
    public float b_SpeedValue=335f;
    public BoxCollider left;
    public BoxCollider right;

    Vector3 b_Movement;
    public bool leftFrame=false;
    public bool rightFrame=true;
    float b_Speed;
    public bool lin = true;
    public bool rin = true;

    float randomForFrame;
    
    void Start()
    {
        b_Rigidbody=GetComponent<Rigidbody>();
        b_Speed=b_SpeedValue*Time.deltaTime;
        randomForFrame=randomGenerate();
    }

    void update()
    {
        b_Speed=b_SpeedValue*Time.deltaTime;
    }

    void FixedUpdate()
    {
        if(randomForFrame>=0.5)
        {
            if(rin)
            {
                float x=right.transform.position.x;
                float y=Random.Range(0,70);
                b_Movement.Set(x,y,0);
                bird.position=b_Movement;
                bird.rotation = Quaternion.Euler(0, 180, 0);
                rin=false;
                //lin=false;
            }

            b_Movement.Set(-b_Speed,0,0);
            bird.position+=b_Movement;
        }
        if(randomForFrame<0.5)
        {
            if(lin)
            {
                float x=left.transform.position.x;
                float y=Random.Range(0,30);
                b_Movement.Set(x,y,0);
                bird.position=b_Movement;
                bird.rotation = Quaternion.Euler(0, 0, 0);
                lin=false;
                //rin=false;
            }
            
            b_Movement.Set(b_Speed,0,0);
            bird.position+=b_Movement;
        }
        if(rightFrame) 
        {
            randomForFrame=randomGenerate();
            rightFrame=false;
            lin=true;
            rin=true;
        }
        if(leftFrame)
        {
            randomForFrame=randomGenerate();
            leftFrame=false;
            rin=true;
            lin=true;
        } 
    }

    float randomGenerate()
    {
        float rFrame;
        rFrame=Random.value;
        return rFrame;
    }
}
