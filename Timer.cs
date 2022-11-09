using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timer=120;
    public Text textoTimer;
    private bool enMarcha;
    private void Start()
    {
        enMarcha = true;
    }

    void Update()
    {
        if (enMarcha)
        {
            timer -= Time.deltaTime;
            textoTimer.text = "" + timer.ToString("f0");
            if (timer<= 0f)
            {
                SceneManager.LoadScene("MenuPrincipal");
            }
        }
    }
    
}
