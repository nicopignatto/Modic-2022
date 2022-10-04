using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicParedesMovedizas : MonoBehaviour
{
    [Header("Vel de movimiento de paredes movedizas")]
    [SerializeField] private float velParedesMovedizas;

    [Header("Posiciones de las paredes")]
    [SerializeField] private float limiteIzq;
    [SerializeField] private float limiteDer;

    /*[Header("Linkeos")]
    [SerializeField] private Rigidbody rbPared;*/

    //variables privadas
    private bool Izquierda;

    private void Start()
    {
        Izquierda = false;
    }

    private void FixedUpdate()
    {
        MovParedesMovedizas();

    }

    private void MovParedesMovedizas()
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
}
