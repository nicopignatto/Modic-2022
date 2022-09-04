using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorAparicionF : MonoBehaviour
{
    [Header("Coldown para activar el Fuego")]
    [SerializeField] private float coldownFuegoApar;//representa el tiempo que tarda el fuego en aparecer ante el jugador.

    [Header("Linkeos")]
    [SerializeField] private GameObject fuegoEnemigo;

    //variables privadas
    private float tiempoActualFuegoApar;
    

    private void Start()
    {
        tiempoActualFuegoApar = 0f;
        fuegoEnemigo.SetActive(false);
        
    }

    private void Update()
    {
        AparicionDelFuego();
    }

    private void AparicionDelFuego()
    {
        if (fuegoEnemigo.activeInHierarchy == false)
        {
            if (tiempoActualFuegoApar > coldownFuegoApar)
            {
                fuegoEnemigo.SetActive(true);
                tiempoActualFuegoApar = 0f;

            }
            tiempoActualFuegoApar += Time.deltaTime;
            //Debug.Log("Tiempo actual fuego aparicion: " + tiempoActualFuegoApar);
        }
    }
}
