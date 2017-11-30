using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyController : MonoBehaviour {

    private SteamVR_TrackedController device;

    public GameObject menuObject;
    public GameObject userCam;
    public bool menuOpen = false;

    // Use this for initialization
    void Start () {
        device = GetComponent<SteamVR_TrackedController>();
        device.TriggerClicked += Trigger;
        device.MenuButtonClicked += Menu;

        menuObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Trigger(object sender, ClickedEventArgs e) {
        Debug.Log("Trigger has been pressed.");

	}

    void Menu(object sender, ClickedEventArgs e)
    {
        Debug.Log("Menu has been pressed.");

        menuOpen = !menuOpen;

        menuObject.SetActive(menuOpen);


        if (menuOpen == true)
        {
            menuObject.transform.position = transform.position;
            menuObject.transform.rotation = userCam.transform.rotation;
            Time.timeScale = 0;
        }
        else
        {

            Time.timeScale = 1;

        }



    }
}
