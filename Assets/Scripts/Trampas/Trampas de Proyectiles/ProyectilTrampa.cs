using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilTrampa : MonoBehaviour
{
    [Header("Vel. de movimiento de la bala de la trampa")]
    [SerializeField] private float velMovTrampaProyectil;

    [Header("Linkeos")]
    [SerializeField] private Rigidbody rbProyectilTrampa;

    private void FixedUpdate()
    {
        MovimientoProyectilTrampa();
    }

    private void MovimientoProyectilTrampa()
    {
        rbProyectilTrampa.velocity = Vector3.forward * velMovTrampaProyectil;
    }
}
