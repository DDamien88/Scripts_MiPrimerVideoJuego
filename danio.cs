using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class danio : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("zombie"))
        {
            Destroy(other.gameObject);
            Debug.Log("daño al enemigo");
        }
    }
}
