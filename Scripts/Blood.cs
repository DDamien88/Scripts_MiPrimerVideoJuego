using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blood : MonoBehaviour
{
    private ParticleSystem sg;
    void Start()
    {
        sg = GetComponent<ParticleSystem>();
        sg.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
