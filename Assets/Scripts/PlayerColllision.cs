using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColllision : MonoBehaviour
{
    public TimerScript timerScript;

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Caja"))
        {
            timerScript.gameOver = true;

            Destroy(gameObject);
        }
    }
}