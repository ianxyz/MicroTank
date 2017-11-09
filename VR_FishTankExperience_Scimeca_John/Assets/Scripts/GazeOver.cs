using UnityEngine;
using System.Collections;

public class GazeOver : MonoBehaviour {


    public bool gazedAt = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (gazedAt == true)
        {
            //actual things to do when you are being looked at

            Debug.Log("You saw me");



        }
	
	}
}
