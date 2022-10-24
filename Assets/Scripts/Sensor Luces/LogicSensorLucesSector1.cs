using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicSensorLucesSector1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Jugador"))
        {
            //Debug.Log("colisione con el jugador");
            LogicSectoresLuces.Sector1Activado = true;
            LogicSectoresLuces.Sector2Activado = false;
        }
        else
        {
            //Debug.Log("no colisione con nada bb");
            LogicSectoresLuces.Sector1Activado = false;
            LogicSectoresLuces.Sector2Activado = true;
        }
    }
}
