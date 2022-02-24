using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public Bird bird;
    public Transform t_Bird;
    public GameObject orange;
    public GameObject peer;
    public Transform t_Orange;
    public Transform t_Peer;
    bool decide;

    float randomForFruit;
    void start()
    {
        randomForFruit=randomGenerate();
        if(randomForFruit>=3)
        {
          decide=true;
        }
        else
        {
            decide=false;
        }
        orange.SetActive(decide);
        peer.SetActive(!decide);
    }

    void update()
    {
        t_Orange.position=t_Bird.position;
        t_Peer.position=t_Bird.position;
    }

    float randomGenerate()
    {
        float rFrame;
        rFrame=Random.Range(1,5);
        return rFrame;
    }
}
