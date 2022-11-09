using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIBoss : MonoBehaviour
{
    public Transform objetivo;
    public float velocidad;
    public NavMeshAgent ia;
    public Animation Anim;
    public string NombreAnimacionCaminar;
    public string NombreAnimacionAtacar;
    public float dano;
    void Update()
    {
        ia.speed = velocidad;
        ia.SetDestination(objetivo.position);
        if (ia.velocity == Vector3.zero)
        {
            Anim.CrossFade(NombreAnimacionAtacar);
        }
        else
        {
            Anim.CrossFade(NombreAnimacionCaminar);
        }
    }
    public void Ataque()
    {
        objetivo.GetComponent<Codigo_Salud>().RecibirDano(dano);
    }
}
