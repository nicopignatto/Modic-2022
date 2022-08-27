using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour
{
    //este codigo funciona pero le falta orden y mejor estructuracion pero anda bien y eso es lo que importa.
    public CharacterController controller;
    public Transform groundcheck;
    public LayerMask groundmask;
    public float speed = 10f;
    public float gravity = -9.8f;
    public float jumpheight = 2f;
    public float grounddistance = 0.3f;
    bool isgrounded;
    Vector3 velocity;
   
   static private bool muerto;

    static public bool Muerto
    {
        get
        {
            return muerto;
        }

        set
        {
            muerto = value;
        }
    }

    void Start()
    {
        muerto = false;
    }

  
    void Update()
    {
        isgrounded = Physics.CheckSphere(groundcheck.position, grounddistance, groundmask);
        
        if(isgrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump")&& isgrounded)
        {
            velocity.y = Mathf.Sqrt(jumpheight * -2 * gravity);
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Trampa" || collision.gameObject.tag == "Fuego")
        {
            //Debug.Log("Me muero");
            muerto = true;
            this.gameObject.SetActive(false);
        }
    }
}