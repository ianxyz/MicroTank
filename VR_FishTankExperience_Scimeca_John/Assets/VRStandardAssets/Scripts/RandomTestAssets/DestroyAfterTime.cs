using UnityEngine;
using System.Collections;

public class DestroyAfterTime : MonoBehaviour {

    //set the number of seconds until this object is destroyed
    [SerializeField]
    private float DestroyMeInSeconds = .5f;
	
	void Start () {
        Destroy(gameObject, DestroyMeInSeconds);
	}
}
