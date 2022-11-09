using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golpe : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        GameObject objeto = col.gameObject;
        
        if (objeto.name.Equals("Zombie"))
        {

            Destroy(objeto);
        }
    }
}
