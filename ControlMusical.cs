using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlMusical : MonoBehaviour
{
    public static ControlMusical musicaMenu;

    private void Awake()
    {
        this.ControlInstancia();
    }

    private void ControlInstancia()
    {
        if (musicaMenu == null)
        {
            musicaMenu = this;
            DontDestroyOnLoad(this);
        }
        else if (this !=musicaMenu)
        {
            Destroy(this.gameObject);
        }
        
    }
}

