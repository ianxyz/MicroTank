using UnityEngine;
using System.Collections;

public class LookAtCamera : MonoBehaviour {

    public Transform LookAtMe;
	
	
	void Update () {
        transform.LookAt(LookAtMe);
	}

}
