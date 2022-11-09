using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicaObjetoDestruible3 : MonoBehaviour
{
    public float danioPorGolpe;
    public float vidaDelObjeto;
    float vidaActualDelObjeto;
    public Text saludEnemy3;
    public ParticleSystem sg;
    private AudioSource zombi;
    public AudioClip golpeHacha;
    float countdown;
    private float delay = 1;

    void Start()
    {
        zombi = GetComponent<AudioSource>();
        vidaActualDelObjeto = vidaDelObjeto;
        countdown = delay;
    }
    void Update()
    {
        countdown -= Time.deltaTime;
        saludEnemy3.text = vidaActualDelObjeto.ToString();
        if (vidaActualDelObjeto <= 0)
        {
            gameObject.GetComponent<BoxCollider>().enabled = false;
            Destroy(gameObject,delay);

        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("AtaqueJugador"))
        {
            Instantiate(sg, other.gameObject.transform.position, Quaternion.identity);
            vidaActualDelObjeto -= danioPorGolpe;
            zombi.PlayOneShot(golpeHacha);
            Debug.Log(vidaActualDelObjeto);
        }
    }
}

