using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class tiempo : MonoBehaviour
{
    public Text cont;
    private float i = 0f;

    public void Start()
    {
       cont = GetComponent<Text>();
    }

    private void FixedUpdate()
    {
        i = i + 0.1f;
        StartCoroutine("Mostrar");
        cont.text = "" + i;

    }
    public IEnumerator Mostrar()
    {
        yield return new WaitForSeconds(1);
        
    }
    
}
