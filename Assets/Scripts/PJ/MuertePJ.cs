using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuertePJ : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Trampa"))
        {
            Debug.Log("me mataron");
            Destroy(this.gameObject);
        }

    }

    
}
