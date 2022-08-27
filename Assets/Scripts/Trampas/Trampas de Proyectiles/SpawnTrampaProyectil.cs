using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrampaProyectil : MonoBehaviour
{
    [Header("Tiempo entre disparo de proyectil de la trampa")]
    [SerializeField] private float coldownTrampaProyectil;

    [Header("Linkeos")]
    [SerializeField] private GameObject proyectilTrampaPrefab;

    //variables privadas
    private float tiempoActualTrampaProyectil;

    private void Start()
    {
        tiempoActualTrampaProyectil = coldownTrampaProyectil + 1f;
    }

    private void Update()
    {
        SpawnearProyectilTrampa();
    }

    private void SpawnearProyectilTrampa()
    {
        if (SensorTrampa.ColisioneConAlgo && PlayerMove.Muerto == false)
        {

            if (tiempoActualTrampaProyectil > coldownTrampaProyectil)
            {
                //Debug.Log("Disparo proyectil trampa");
                Instantiate(proyectilTrampaPrefab, this.transform.position, proyectilTrampaPrefab.transform.rotation);
                tiempoActualTrampaProyectil = 0f;
            }

            tiempoActualTrampaProyectil += Time.deltaTime;
        }
    }
}