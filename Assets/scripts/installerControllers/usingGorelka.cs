using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class usingGorelka : MonoBehaviour
{
    public usingBalon usingBalon;
    public ParticleSystem fire;
    void Start()
    {
        fire.Stop();   
    }

    void Update()
    {
        if(usingBalon.turnOn)
            fire.Play();
        else
            fire.Stop();
        
    }
}
