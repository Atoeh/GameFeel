using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class StartButton : MonoBehaviour
{
    public bool delayOver;
    public float loadingTime = .5f;

    public GameObject loadingPanel;

    void Start()
    {
        loadingPanel.SetActive(false);
        delayOver = false;
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            loadingPanel.SetActive(true);
            Debug.Log("Trigger");
        }
    }

    public void StartGame()
    {
    }

    public void StartLoading()
    {
        
    }

    IEnumerator DelaySwitch()
    {
        yield return new WaitForSeconds(loadingTime);
        delayOver = true;
    }
}
