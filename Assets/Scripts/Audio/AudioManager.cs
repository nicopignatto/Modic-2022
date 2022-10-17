using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour
{
    public AudioClip[] audioClips;
    public AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    /// <summary>
    /// indice es la pista de audio a utilizar, volumen es el volumen, loopear es true o false
    /// </summary>
    /// <param name="indice"></param>
    /// <param name="volumen"></param>
    /// <param name="loopear"></param>
    public void SeleccionDeAudio(int indice, float volumen, bool loopear)
    {
        audioSource.PlayOneShot(audioClips[indice], volumen);
        audioSource.loop = loopear;
    }
}