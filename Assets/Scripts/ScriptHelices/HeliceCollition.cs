using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeliceCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Helice"))
        {
            col.gameObject.GetComponent<CajaSpawner>().LocateBoxAtRandomPosition();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
