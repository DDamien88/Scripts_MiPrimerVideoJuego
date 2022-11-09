using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Codigo_Salud : MonoBehaviour
{
    public ProtMuere2 personaje;
    public float salud = 100;
    public float saludMaxima = 100;
     Text saludProt;

    
    void Update()
    {
        ActualizarInterfaz();
    }
    public void RecibirDano(float dano)
    {
        salud -= dano;
        if (salud<=0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("YourLoose_escena2");
        }
    }
     public void ActualizarInterfaz()
    {
        personaje.saludProt.text = salud.ToString();
    }
}
