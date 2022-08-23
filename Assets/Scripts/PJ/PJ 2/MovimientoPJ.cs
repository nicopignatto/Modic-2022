using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPJ : MonoBehaviour
{
    [Header("Vel. del jugador")]
    [SerializeField] private float velMov;

    [Header("Linkeos")]
    [SerializeField] private Rigidbody rb;

    private void FixedUpdate()
    {
        MovPJ();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Trampa")
        {
            Debug.Log("me muero");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Trampa")
        {
            Debug.Log("Me triggeo algo");
        }
    }

    private void MovPJ()
    {
        float inputHorizontal = Input.GetAxis("Horizontal");
        float inputVertical = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(inputVertical * velMov, rb.velocity.y, rb.velocity.z);
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, inputHorizontal * velMov);
        //transform.Translate(Vector3.forward * velMov * inputHorizontal);
        //transform.Translate(Vector3.right * velMov * inputVertical);
    }
}
