using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class siguiente : MonoBehaviour
{
     public void pasarAOtroNivel()
     {
        SceneManager.LoadScene("EscenaIntro");
     }
}
