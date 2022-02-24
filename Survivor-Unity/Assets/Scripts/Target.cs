using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;
    public GameObject gameObj;




    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        StartCoroutine(ActivationRoutine());
    }
    private IEnumerator ActivationRoutine()
    {
        gameObj.SetActive(false);
        yield return new WaitForSeconds(3);
        gameObj.SetActive(true);
    }


}