using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Nueva trampa", menuName = "Scriptable Objects/Trampas/Trampa Movil")]
public class TrampaMovilSO : ScriptableObject
{
    [Header("Vel de movimiento de la trampa")]
    [Range(0.1f,1f)]
    [SerializeField] private float velMovTrampaMovil;

    [Header("Limites de movimiento de la trampa movil")]
    [SerializeField] private float limiteIzq;
    [SerializeField] private float limiteDer;

    [Header("Linkeos")]
    [SerializeField] private Rigidbody rbTrampaMovil;
}
