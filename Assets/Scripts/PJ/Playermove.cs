using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour
{
    //este codigo funciona pero le falta orden y mejor estructuracion pero anda bien y eso es lo que importa.
    public CharacterController controller;
    public float speed = 10f;
    public float gravity = -9.8f;
    public float jumpheight = 2f;
    public Transform groundcheck;
    public float grounddistance = 0.3f;
    public LayerMask groundmask;
    Vector3 velocity;
    bool isgrounded;

    void Start()
    {
      
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
}
