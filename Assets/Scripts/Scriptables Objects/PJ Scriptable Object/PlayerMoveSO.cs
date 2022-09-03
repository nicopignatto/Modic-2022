using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Nuevo PJ",menuName ="Scriptable Objects/PJ")]
public class PlayerMoveSO : ScriptableObject
{
    [Header("Velocidad de movimiento")]
    [SerializeField] private float velMov;

    [Header("Linkeos")]
    [SerializeField] Rigidbody rbPJ;

    public float VelMov
    {
        get
        {
            return velMov;
        }

        set
        {
            velMov = value;
        }
    }

    public Rigidbody RbPJ
    {
        get
        {
            return rbPJ;
        }
    }
}
