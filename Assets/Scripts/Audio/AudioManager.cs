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
            musica.Play();
        }
    }

    void Update()
    {
        if (Time.timeScale == 1f) Continuar();
        else Parar();
    }

    void Parar()
    {
        foreach(AudioSource a in audioSources)
        {
            a.Stop();
        }
    }
    void Continuar()
    {
        foreach(AudioSource a in audioSources)
        {
            a.Play();
        }
    }
}