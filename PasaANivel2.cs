using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PasaANivel2 : MonoBehaviour
{
    public LogicaObjetoDestruible next;
    public LogicaObjetoDestruible2 next1;
    public LogicaObjetoDestruible3 next2;
    public LogicaObjetoDestruible4 next3;
    float vidaActualDelObejto = 100;


    void Update()
    {
        next.ToString();
        next1.ToString();
        next2.ToString();
        next3.ToString();

        if (next && next1 && next2 && next3 && vidaActualDelObejto<=0)
            {

                SceneManager.LoadScene("Escena2");

            }
        
        
    }
}
