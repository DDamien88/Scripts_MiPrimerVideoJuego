using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaDelAtaque : MonoBehaviour
{
    public Animator jugadorAnim;
    public ControlDelPersonaje jugadorScript;
    public GameObject colliderAtaque;
    
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && jugadorScript.estaEnElSuelo)
        {
            jugadorAnim.SetTrigger("Ataca");
        }
    }
    public void Ataca()
    {
        jugadorScript.canMove = false;
        colliderAtaque.SetActive(true);
    }
    public void DejaDeAtacar()
    {
        jugadorScript.canMove = true;
        colliderAtaque.SetActive(false);
    }
   
   

}
