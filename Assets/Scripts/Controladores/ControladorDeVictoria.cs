using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using System;
public class ControladorDeVictoria : MonoBehaviour
{
    [SerializeField] GameObject panel;
    public bool isactivated = false;


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("funciona");
        if (other.tag == "Jugador" && !isactivated)
        {
            isactivated = true;

            panel.SetActive(true);
        }
    }
}