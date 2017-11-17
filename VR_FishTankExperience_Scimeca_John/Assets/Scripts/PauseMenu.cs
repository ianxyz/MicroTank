using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public GameObject menuObject;
    private bool menuOpen = false;

	// Use this for initialization
	void Start () {
        menuObject.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space"))
        {
            menuOpen = !menuOpen;
           
            menuObject.SetActive(menuOpen);
            

            if (menuOpen == true)
            {
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
     
            }
            
        }





	}
}
