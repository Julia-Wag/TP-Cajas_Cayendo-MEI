using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaMovement : MonoBehaviour
{
    public float speed = 6f;

    public TimerScript timerScript;
    
    void Update()
    {
        if(timerScript.gameOver == false)
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }
    }
}