using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraLook : MonoBehaviour
{
    public float mousesensivility = 1500f;
    public Transform playerbody;
    float xRotation = 0f;
    void Start()
    {
        
    }

    
    void Update()
    {
        float mousex = Input.GetAxis("Mouse X") * mousesensivility * Time.deltaTime;
        float mousey = Input.GetAxis("Mouse Y") * mousesensivility * Time.deltaTime;
        xRotation -= mousey;
        xRotation = Mathf.Clamp(xRotation, -90f, 90);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerbody.Rotate(Vector3.up * mousex);
    }
}
