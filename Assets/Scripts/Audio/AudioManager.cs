using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour
{
    [SerializeField] GameObject[] sonido;
    [SerializeField] AudioSource[] audioSources;
    PauseMenu pause;

    private void Start()
    {
        foreach(AudioSource musica in audioSources)
        {
            musica.volume = 0.5f;
        }
    }   
}