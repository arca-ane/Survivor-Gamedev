using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lvl1score : MonoBehaviour
{
    public Text txtscore;
    public Variables score;
    
   
     /*[SerializeField]
     private float _changeInterval = 1;
     [SerializeField]
     private Color[] _possibleColors = null;
     private void OnEnable()
     {
         // Kick off the change color routine, which is automatically stopped by OnDisable
         StartCoroutine(ChangeColorAsync());
     }
     private IEnumerator ChangeColorAsync()
     {
         // Create a wait object based on our interval, outside of loop to avoid extra allocations
         var wait = new WaitForSecondsRealtime(_changeInterval);
         while (enabled)
         {
             // Change text color to one of our possible colors
             txtscore.color = _possibleColors[Random.Range(0, _possibleColors.Length)];
             // Wait
             yield return wait;
         }
     }*/

      void Update()
    {
        //OnEnable();
        txtscore.text="Final Score is :" + score.value;
        
        //score.value=0;
    }

}
