using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class danioDelPrincipal : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("zombie"))
        {
            Destroy(other.gameObject);
            Debug.Log("da?o al enemigo");
        }
    }

}
