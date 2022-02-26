using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scored : MonoBehaviour
{
    public Text textScore;
    public Variables Score;

    void Update()
    {
        textScore.text="Score: " + Score.value;
    }

}
