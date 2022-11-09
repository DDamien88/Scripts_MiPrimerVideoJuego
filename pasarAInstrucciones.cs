using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pasarAInstrucciones : MonoBehaviour
{
    public void pasarAInstruc()
    {
        SceneManager.LoadScene("Instrucciones");

    }
}
