using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EfectoSangre : MonoBehaviour
{
    public GameObject coll;
    public Image sangreEfecto;
    private float r;
    private float g;
    private float b;
    private float a;
   
    void Start()
    {
       
        r = sangreEfecto.color.r;
        g = sangreEfecto.color.g;
        b = sangreEfecto.color.b;
        a = sangreEfecto.color.a;
        
    }
    void OnTriggerEnter(Collider col)
    {
        GameObject objeto = coll.gameObject;
        Debug.Log("entró");
      

        if (coll.name.Equals("zombie"))
        {
            CambiarColor();
            a += 0.01f;
        }

    }


    /*private void OnTriggerEnter(Collider other)
      {
              if (other.gameObject.CompareTag("zombie"))
              {
              a += 0.01f;

          }


      }*/
    void Update()
    {

        a -= 0.001f;
        a = Mathf.Clamp(a, 0, 1f);
        CambiarColor();
    }

    
    private void CambiarColor()
    {
        Color c = new Color(r, g, b, a);
        sangreEfecto.color = c;
    }
}
