using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Limiter : MonoBehaviour {

    public AudioSource AudioWater;

	// Use this for initialization
	void Start () {
		
	}
	

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerHead"))
            {
            Debug.Log("It happened.");
            AudioWater.volume = 0;

        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PlayerHead"))
        {
            Debug.Log("It un-happened.");
            AudioWater.volume = 1;
        }
    }
}
