using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    

    public class danioDelEnemigo : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("principal"))
        {
            Debug.Log("da�o del enemigo");
        }
    }
}
