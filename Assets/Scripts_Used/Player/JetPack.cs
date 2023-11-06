using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetPack : MonoBehaviour
{
   
    public ParticleSystem effect_1;
    public ParticleSystem effect_2;

    void Start()
    {
        effect_1.Play();
        effect_2.Play();
    }

    // Update is called once per frame
    
}