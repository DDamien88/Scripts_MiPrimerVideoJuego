using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ProtMuere2 : MonoBehaviour
{
    public float danioPorGolpe;
    public float vidaDelObjeto;
    float vidaActualDelObjeto;
    public Text saludProt;

    void Start()
    {

        vidaActualDelObjeto = vidaDelObjeto;
    }
    void Update()
    {
        saludProt.text = vidaActualDelObjeto.ToString();

        if (vidaActualDelObjeto <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("YourLoose_escena2");

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("zombie"))
        {
            vidaActualDelObjeto -= danioPorGolpe;
            Debug.Log(vidaActualDelObjeto);
        }
    }

}
