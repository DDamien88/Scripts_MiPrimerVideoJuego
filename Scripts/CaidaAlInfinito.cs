using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaidaAlInfinito : MonoBehaviour
{
    public Transform startPosition;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Subsuelo"))
        {
            GetComponent<CharacterController>().enabled = false;
            gameObject.transform.position = startPosition.position;
            GetComponent<CharacterController>().enabled = true;
        }
    }
    
}
