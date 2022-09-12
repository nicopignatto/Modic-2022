using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Movimiento : MonoBehaviour
{
    private Rigidbody EnemyRb;
    private GameObject Player;

    public float speed = 2;
    void Start()
    {
        EnemyRb = GetComponent<Rigidbody>();
        Player = GameObject.Find("Player 1");
    }
    void Update()
    {
        if (Player.activeInHierarchy && Playermove.Muerto == false)
        {
            Vector3 MirarAlPlayer = (Player.transform.position - transform.position).normalized;
            EnemyRb.AddForce(MirarAlPlayer * speed);

        }
        else
        {
            //Debug.Log("Se desactivo el fuego");
            this.gameObject.SetActive(false);
        }
        
    }
}