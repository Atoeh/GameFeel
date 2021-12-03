using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddDust : MonoBehaviour
{

    public ParticleSystem particle;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.Space))
        {
            particle.Play();
            //Debug.Log("turned on");
        }
        else
        {
            //particle.Stop();
        }

    }
}
