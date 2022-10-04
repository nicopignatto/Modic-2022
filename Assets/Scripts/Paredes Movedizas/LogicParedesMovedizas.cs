using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicParedesMovedizas : MonoBehaviour
{
    [Header("Vel de movimiento de paredes movedizas")]
    [SerializeField] private float velParedesMovedizas;

    [Header("Tipos de movimientos de las paredes")]
    [SerializeField] private bool mueveIzqDer;
    [SerializeField] private bool mueveArribaAbajo;

    [Header("Posiciones de las paredes")]
    [SerializeField] private float limiteIzq;
    [SerializeField] private float limiteDer;
    [SerializeField] private float limiteArriba;
    [SerializeField] private float limiteAbajo;

    /*[Header("Linkeos")]
    [SerializeField] private Rigidbody rbPared;*/

    //variables privadas
    private bool Izquierda;
    private bool Arriba;

    private void Start()
    {
        //Izquierda = false;
        //Arriba = false;
        //mueveIzqDer = false;
    }

    private void FixedUpdate()
    {
        MovParedesMovedizas();

    }

    private void MovParedesMovedizas()
    {
        if (mueveIzqDer)
        {

            if (transform.position.z < limiteIzq)
            {
                Izquierda = true;
            }
            else
            {
                if (transform.position.z > limiteDer)
                {
                    Izquierda = false;
                }
            }


            if (Izquierda)
            {
                transform.Translate(Vector3.left * velParedesMovedizas);
            }
            else
            {
                transform.Translate(Vector3.right * velParedesMovedizas);
            }
        }


        if (mueveArribaAbajo)
        {

            if (transform.position.x < limiteArriba)
            {
                Arriba = false;
            }
            else
            {
                if (transform.position.x > limiteAbajo)
                {
                    Arriba = true;
                }
            }

            if (Arriba)
            {
                transform.Translate(Vector3.left * velParedesMovedizas);
            }
            else
            {
                transform.Translate(Vector3.right * velParedesMovedizas);
            }
        }
    }
}
