using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour
{
    [SerializeField] GameObject[] sonido;
    [SerializeField] AudioSource[] audioSources;
    
    void Awake()
    {
        foreach(AudioSource musica in audioSources)
        {
            musica.volume = 0.5f;
        }
    }

    void Update()
    {
        if (PauseMenu.GameIsPause == true) Parar();
        //if (PauseMenu.GameIsPause == false) Reproducir();
    }

    void Parar()
    {
        foreach(AudioSource a in audioSources)
        {
            a.Stop();
        }
    }
}