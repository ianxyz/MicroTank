using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyController : MonoBehaviour {

    private SteamVR_TrackedController device;
    
	// Use this for initialization
	void Start () {
        device = GetComponent<SteamVR_TrackedController>();
        device.TriggerClicked += Trigger;
        device.MenuButtonClicked += Menu;

       
    }
	
	// Update is called once per frame
	void Trigger(object sender, ClickedEventArgs e) {
        Debug.Log("Trigger has been pressed.");
	}

    void Menu(object sender, ClickedEventArgs e)
    {
        Debug.Log("Menu has been pressed.");
        
    }
}
