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
    [SerializeField] Image ImageMute;
    [SerializeField] Image ImageBrillo;

    public float SliderValueM;
    public float SliderValueB;
   
    public Toggle toggle;
    private void Awake()
    {
        LoadChanges();  
    }
    public void start()
    {
        Musicmute();
                        
        AudioListener.volume = SliderMusic.value;
        ImageBrillo.color = new Color(ImageBrillo.color.r, ImageBrillo.color.g, ImageBrillo.color.b, SliderValueB);

        if (Screen.fullScreen) toggle.isOn = true;        
        else toggle.isOn = false;
    }
    private void FixedUpdate()
    {
        SaveChange();
    }
    public void changeSlider(float valor)
    {
        SliderValueM = valor;

        AudioListener.volume = SliderMusic.value;

        Musicmute();
    }
    public void Musicmute()
    {
        if (SliderValueM == 0) ImageMute.enabled = true;
        else ImageMute.enabled = false;
    }
    public void AjusteBrillo(float valor)
    {
        SliderValueB = valor;

        ImageBrillo.color = new Color(ImageBrillo.color.r, ImageBrillo.color.g, ImageBrillo.color.b, SliderBrillo.value);
    }
    public void PantallaCompleta(bool pantallaCompleta)
    {
        Screen.fullScreen = pantallaCompleta;
    }
    private void OnDestroy()
    {
        SaveChange();
    }
    private void SaveChange()
    {
        PlayerPrefs.SetFloat("VolumenMusic", SliderMusic.value);
        PlayerPrefs.Save();
        PlayerPrefs.SetFloat("brillo", SliderBrillo.value);
        PlayerPrefs.Save();
    }
    private void LoadChanges()
    {
        SliderBrillo.value = PlayerPrefs.GetFloat("brillo");
        SliderMusic.value = PlayerPrefs.GetFloat("VolumenMusic");
    }
}