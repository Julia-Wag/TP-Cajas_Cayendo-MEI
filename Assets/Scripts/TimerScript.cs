using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour
{
    public TextMeshProUGUI timerText;

    float elapsedTime;

    public bool gameOver = false;

    void Update()
    {
        if(gameOver == false)
        {
            elapsedTime += Time.deltaTime;

            timerText.text = elapsedTime.ToString("F2");
        }
    }
}