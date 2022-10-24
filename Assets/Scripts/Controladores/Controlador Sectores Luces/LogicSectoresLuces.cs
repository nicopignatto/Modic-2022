using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicSectoresLuces : MonoBehaviour
{
    [Header("Linkeos")]
    [SerializeField] private GameObject lucesSector1;
    [SerializeField] private GameObject lucesSector2;


    //variables privadas
    static private bool sector1Activado;
    static private bool sector2Activado;

    static public bool Sector1Activado
    {
        get { return sector1Activado; }
        set { sector1Activado = value; }
    }
    static public bool Sector2Activado
    {
        get { return sector2Activado; }
        set { sector2Activado = value; }
    }

    private void Start()
    {
        sector1Activado = true;
        sector2Activado = false;
    }

    private void Update()
    {
        ActivarYDesactivarLuces();
    }

    private void ActivarYDesactivarLuces()
    {
        if (sector1Activado)
        {
           lucesSector1.SetActive(true);
        }
        else
        {
            lucesSector1.SetActive(false);
        }

        if (sector2Activado)
        {
            lucesSector2.SetActive(true);
        }
        else
        {
            lucesSector2.SetActive(false);
        }
    }
}
