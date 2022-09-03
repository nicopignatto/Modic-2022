using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using System;
public class Audio_mixer : MonoBehaviour
{
    [SerializeField] AudioMixer audiomixer;
    [SerializeField] Slider SliderMusic;
    const string Mixer_Music = "VolumenMusic";
    private void Awake()
    {
        SliderMusic.onValueChanged.AddListener(Music);
    }
    void Update()
    {
        
    }
    void Music(float valor)
    {
        if (valor != 0)
        {
         audiomixer.SetFloat(Mixer_Music, Mathf.Log10(valor) * 20);
        }
    }
}