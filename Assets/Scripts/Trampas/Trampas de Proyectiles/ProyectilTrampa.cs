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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Pared" || collision.gameObject.tag == "Jugador")
        {
            //Debug.Log("Se destruyo la bala");
            Destroy(this.gameObject);
            //this.gameObject.SetActive(false);
        }
    }

    private void MovimientoProyectilTrampa()
    {
        rbProyectilTrampa.velocity = Vector3.forward * velMovTrampaProyectil;
    }
}
