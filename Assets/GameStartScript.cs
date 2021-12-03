using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartScript : MonoBehaviour
{
    //public Animator transition;
    public GameObject loadingScreen;
    public float loadingTime = 5f;
    public bool doneLoading;

    // Start is called before the first frame update
    void Start()
    {
        doneLoading = false;
        loadingScreen.SetActive(true);
        StartCoroutine(Intro());
    }
     
    // Update is called once per frame
    void Update()
    {
        Debug.Log(doneLoading);
        if (doneLoading == true)
        { 
            loadingScreen.SetActive(false);
        }
    }

    IEnumerator Intro()
    { 
        //transition.SetTrigger("StartGame");
        yield return new WaitForSeconds(loadingTime);
        doneLoading = true;
        Debug.Log("DoneLoading");
    }
}
