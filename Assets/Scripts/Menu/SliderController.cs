using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using System;
public class SliderController : MonoBehaviour
{
    [SerializeField] Slider SliderMusic;
    [SerializeField] Slider SliderBrillo;
    public Image ImageMute;
    public Image ImageBrillo;
    public float SliderValueM;
    public float SliderValueB;
    public Toggle toggle;
    const string Mixer_Music = "VolumenMusic";
    public void start()
    {
        SliderMusic.value = PlayerPrefs.GetFloat(Mixer_Music, 0.5f);       
        AudioListener.volume = SliderMusic.value;
        Musicmute();
        SliderBrillo.value = PlayerPrefs.GetFloat("brillo", 0.5f);
        ImageBrillo.color = new Color(ImageBrillo.color.r, ImageBrillo.color.g, ImageBrillo.color.b, SliderValueB);
        if (Screen.fullScreen)
        {
            toggle.isOn = true;
        }
        else
        {
            toggle.isOn = false;
        }
    }
    public void changeSlider(float valor)
    {
        SliderValueM = valor;
        PlayerPrefs.SetFloat(Mixer_Music, SliderValueM);
        AudioListener.volume = SliderMusic.value;
        Musicmute();
    }
    public void Musicmute()
    {
        if (SliderValueM == 0)
        {
            ImageMute.enabled = true;
        }
        else
        {
            ImageMute.enabled = false;
        }
    }
    public void AjusteBrillo(float valor)
    {
        SliderValueB = valor;
        PlayerPrefs.SetFloat("brillo", SliderValueB);
        ImageBrillo.color = new Color(ImageBrillo.color.r, ImageBrillo.color.g, ImageBrillo.color.b, SliderBrillo.value);
    }
    public void PantallaCompleta(bool pantallaCompleta)
    {
        Screen.fullScreen = pantallaCompleta;
    }
}