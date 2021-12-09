using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class QuitTrigerScript : MonoBehaviour
{
    //toevoegen panel
    //toevoegen delay
    // na delay/animatie voorbij, switch zwart scherm

    public GameObject panel1;
    public GameObject panel2;
    public float delayTime = 1.5f;

    void Start()
    {
        panel1.SetActive(false);
        panel2.SetActive(false);
    }
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            panel1.SetActive(true);
            StartCoroutine(Delay());
        }
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(delayTime);
        panel2.SetActive(true);
        panel1.SetActive(false);
    }

    public void QuitGame()
    {
        panel1.SetActive(true);
        StartCoroutine(Delay());
    }
}
