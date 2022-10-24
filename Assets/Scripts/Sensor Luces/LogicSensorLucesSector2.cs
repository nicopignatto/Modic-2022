using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicSensorLucesSector2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Jugador"))
        {
            //Debug.Log("el sector 2 colisiono con el jugador");
            LogicSectoresLuces.Sector2Activado = true;
            LogicSectoresLuces.Sector1Activado = false;
        }
        else
        {
            //Debug.Log("el sector 2 no colisiona con el jugador");
            LogicSectoresLuces.Sector2Activado = false;
            LogicSectoresLuces.Sector1Activado = true;
        }
    }
}
