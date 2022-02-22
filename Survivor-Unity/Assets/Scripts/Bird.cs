using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    Vector3 m_Movement;
    public Transform bird;

    void Start()
    {
        m_Rigidbody=GetComponent<Rigidbody>();
    }

    
    void FixedUpdate()
    {
        float horizontal   = Input.GetAxis("Horizontal");
        
        m_Movement.Set(horizontal,0f,0f);
        m_Movement.Normalize();
        bird.position+=m_Movement; 
    }
}
