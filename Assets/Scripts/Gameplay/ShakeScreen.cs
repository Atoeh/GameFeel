using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeScreen : MonoBehaviour
{
    public GameObject cam;

    private float shakeTimeRemaining, shakePower;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        StartShake(1f, .2f);
    }

    private void LateUpdate()
    {
        shakeTimeRemaining -= Time.deltaTime;

        float xAmount = Random.Range(-1f, 1) * shakePower;
        float yAmount = Random.Range(-1f, 1) * shakePower;

        cam.transform.position += new Vector3(xAmount, yAmount, 0f);

        if (shakeTimeRemaining < 0f)
        { 
            StartShake(0f, 0f);
            shakeTimeRemaining = 0f;
        }
    }

    public void StartShake(float length, float power)
    {
        shakeTimeRemaining = length;
        shakePower = power;
    }
}

