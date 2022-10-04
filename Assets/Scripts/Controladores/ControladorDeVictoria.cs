using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using System;
public class ControladorDeVictoria : MonoBehaviour
{
    [SerializeField] GameObject panelVictoria;
    public bool isactivated = false;


    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("funciona");
        if (other.tag == "Jugador" && !isactivated)
        {
            isactivated = true;

            panelVictoria.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}