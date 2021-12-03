using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsTriggerTrigger : MonoBehaviour
{
    public GameObject triggerParent;
    public bool mainMenuDisplayed = true;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Changemenu();
        }
    }

    public void Changemenu()
    { 
        if (mainMenuDisplayed == true)
        {
             mainMenuDisplayed = false;
        }
        else
        {
            mainMenuDisplayed = true;
        }
        triggerParent.GetComponent<SettingsTriggerScript>().ChangeMenu(mainMenuDisplayed);
    }

}
