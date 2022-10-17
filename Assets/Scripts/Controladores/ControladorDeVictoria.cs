using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using System;
public class ControladorDeVictoria : MonoBehaviour
{
    [SerializeField] GameObject panelVictoria;

    public AudioManager audioManager;

    public bool isactivated = false;

    void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
    }
    void Update()
    {
        if (isactivated == true)
        {
            EjecutarSonido();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("funciona");
        if (other.tag == "Jugador" && !isactivated)
        {
            isactivated = true;

            panelVictoria.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    void EjecutarSonido()
    {
        if (audioManager)
        {
            if (audioManager.audioClips.Length > 0)
            {
                audioManager.SeleccionDeAudio(2, 0.5f, false);
                //Debug.Log("Ejecuto Sonido");
            }
        }
    }
}