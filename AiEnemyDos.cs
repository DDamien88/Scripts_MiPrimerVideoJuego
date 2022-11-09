using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiEnemyDos : MonoBehaviour
{
    public Transform objetivo;
    public float velocidad;
    public NavMeshAgent ia;

    void Update()
    {
        ia.speed = velocidad;
        ia.SetDestination(objetivo.position);
    }
}
