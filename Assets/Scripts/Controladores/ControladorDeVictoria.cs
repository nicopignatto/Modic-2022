using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
public class ControladorDeVictoria : MonoBehaviour
{
    [SerializeField] GameObject panel;
    public bool isactivated = false;

    private void Start()
    {
        panel = GameObject.Find("PantallaDeVictoria");
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("funciona");
        if (other.tag == "Player" && !isactivated)
        {
            isactivated = true;

            panel.SetActive(true);
        }
    }
}