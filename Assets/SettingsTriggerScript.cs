using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SettingsTriggerScript : MonoBehaviour
{

    public GameObject token;
    public GameObject mainMenuMap;
    public GameObject settingsMap;
    public GameObject quitTrigger;
    public GameObject mainMenu;
    public GameObject settingsMenu;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ChangeMenu(bool mainMenuDisplayed)
    {
        if (mainMenuDisplayed == false)
        {
            settingsMap.SetActive(true);
            mainMenuMap.SetActive(false);
            token.SetActive(false);
            quitTrigger.SetActive(false);
            mainMenu.SetActive(false);
            settingsMenu.SetActive(true);
        }
        else
        {
            mainMenuMap.SetActive(true);
            settingsMap.SetActive(false);
            token.SetActive(true);
            quitTrigger.SetActive(true);
            mainMenu.SetActive(true);
            settingsMenu.SetActive(false);
        }
    }
}
