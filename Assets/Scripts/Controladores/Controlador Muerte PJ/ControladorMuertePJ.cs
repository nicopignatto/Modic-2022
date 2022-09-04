using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorMuertePJ : MonoBehaviour
{
    [Header("Posicion actualizada de la camara 2")]
    [SerializeField] private Vector3 posCamara2Act;

    [Header("Rotacion actualizada de la camara 2")]
    [SerializeField] private Quaternion rotacionCamara2Act;

    [Header("Linkeos")]
    [SerializeField] private GameObject pj;
    [SerializeField] private GameObject camara2;
    [SerializeField] private GameObject techoEscena;//representa el techo del laberinto.
    
    

    
    void Update()
    {
        if (Playermove.Muerto)
        {
            techoEscena.SetActive(false);
            pj.SetActive(false);
            camara2.SetActive(true);
        }
        MoverCamara2();
    }

    private void MoverCamara2()
    {
        if (Playermove.Muerto)
        {
            camara2.transform.position = pj.transform.position + posCamara2Act;
            camara2.transform.rotation = rotacionCamara2Act;
        }
    }
}
