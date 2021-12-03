using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadingScript : MonoBehaviour
{
    public float delayTime = 1.5f;
    public GameObject loadingScreen;

    void Start()
    {
        loadingScreen.SetActive(false);
    }

    public void LoadingScreen()
    { 
        StartCoroutine(Delay());
        loadingScreen.SetActive(true);
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(delayTime);
        StartGame();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
