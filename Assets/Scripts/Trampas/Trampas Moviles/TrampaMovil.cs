using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampaMovil : MonoBehaviour
{
    [Header("Vel de movimiento de la trampa")]
    [SerializeField] private float velMovTrampaMovil;

    [Header("Limites de movimiento de la trampa movil")]
    [SerializeField] private float limiteIzq;
    [SerializeField] private float limiteDer;

    [Header("Linkeos")]
    [SerializeField] private Rigidbody rbTrampaMovil;
    //[SerializeField] private SensorTrampa sensorTrampaMovil;

    //variables privadas
    private bool irAIzquierda;
    void FixedUpdate()
    {
        MovimientoTrampaMovil();   
    }

    private void MovimientoTrampaMovil()
    {
        if (SensorTrampa.ColisioneConAlgo == true && PlayerMove.Muerto == false)
        {
            if (transform.position.z > limiteDer)
            {
                irAIzquierda = true;
            }
            else
            {
                if (transform.position.z < limiteIzq)
                {
                    irAIzquierda = false;
                }
            }

            if (irAIzquierda)
            {
                transform.Translate(Vector3.back * velMovTrampaMovil);
            }
            else
            {
                transform.Translate(Vector3.forward * velMovTrampaMovil);
            }

        }
    }
}
