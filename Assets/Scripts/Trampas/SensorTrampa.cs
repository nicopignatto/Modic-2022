using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensorTrampa : MonoBehaviour
{
    //variables privadas.
    static private bool colisioneConAlgo;

    static public bool ColisioneConAlgo
    {
        get
        {
            return colisioneConAlgo;
        }

        set
        {
            colisioneConAlgo = value;
        }
    }
    private void Start()
    {
        colisioneConAlgo = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Jugador"))
        {
            colisioneConAlgo = true;
        }
    }
}
