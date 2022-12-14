using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossDestruible : MonoBehaviour
{
    public float danioPorGolpe;
    public float vidaDelObjeto;
    float vidaActualDelObjeto;
    public Text saludEnemy;
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
        saludEnemy.text = vidaActualDelObjeto.ToString();

        if (vidaActualDelObjeto <= 0)
        {
            gameObject.GetComponent<CapsuleCollider>().enabled = false;
            Destroy(gameObject, delay);
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

