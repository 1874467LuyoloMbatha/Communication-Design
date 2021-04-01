using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthParticle : MonoBehaviour
{
    public ParticleSystem hButtonParticle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void togglePSystem() 
    {
        if (hButtonParticle.isPlaying)
        {
            hButtonParticle.Stop();
        }
        else 
        {
            hButtonParticle.Play();


        }


    }
}
