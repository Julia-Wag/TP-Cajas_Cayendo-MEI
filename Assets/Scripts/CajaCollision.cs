using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Caja"))
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
