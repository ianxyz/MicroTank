using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class VRSlider: MonoBehaviour {
    //How long it takes to fill the slider
    public float filltime = 2f;
    public bool gazedAt = false;
    public GazeRayReciever myRayReciever;
    //Private variables
    private Slider mySlider;
    private float timer;
  

    private Coroutine fillBarRoutine;

    private float timerRemain;
  

	// Use this for initialization
	void Start () {
        mySlider = GetComponent<Slider>();
        myRayReciever = GetComponent<GazeRayReciever>();
        // if (mySlider == null) Debug.Log("Please Add a Slider Component to this Gameobject");


    }
	
	// Update is called once per frame
	void Update () {

        if (myRayReciever.HitByRay == true)
        {
            timer += Time.deltaTime;
            mySlider.value = timer / filltime;
            if (timer >= filltime)
            {
                OnBarFilled();
            }
        }

        if (myRayReciever.HitByRay == false)
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                timer = 0;
            }
            mySlider.value = timer / filltime;
        }


    }
   
    
    //Fill the bar
    private IEnumerator FillBar()
    {
        //When the bar start to fill, reset the timer.
        timer = 0f;
        //Until the timer is greater than the fill time...
        while (timer < filltime)
        {
           ///... add to the timer the difference between frames.
            timer += Time.deltaTime;
            //Set the value of the slider or the UV based on normalised time.
            mySlider.value = timer / filltime;
            //Wait until the next frame.
            yield return null;
            //If the user is still looking at the bar go on to the next iteration of the loop.
            if (gazedAt)
                continue;
            //If the user is no longer looking at the bar, reset the timer and bar and leave the function.
            timer = 0f;
            mySlider.value = 0f;
            yield break;
        }
        //The bar has been filled.
        OnBarFilled();
    }
    //Unfurls the bar cleanly
    private IEnumerator UnfillBar()
    {
        timerRemain = timer;
        while (timerRemain > 0)
        {
            timerRemain -= Time.deltaTime;
            mySlider.value = timerRemain / filltime;
            yield return null;
        }
    }
    private void OnBarFilled()
    {
        Debug.Log("Do something amazing. Aka Load Fishtank3.");
        SceneManager.LoadScene("FISHTANK03", LoadSceneMode.Single);

    }
}
