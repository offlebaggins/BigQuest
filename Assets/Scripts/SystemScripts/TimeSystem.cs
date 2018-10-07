using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeSystem : MonoBehaviour {

    Text Timer;
    public float timeRemaining = 60;


    // Use this for initialization
    void Start () {
       Timer = GetComponent<Text>();
		
	}
	
	// Update is called once per frame
	void Update () {
        // this causes time to countdown at current frame rate. not sure if that will be a problem 
        // but can move this to fixedupdate to avoid issues
        timeRemaining -= Time.deltaTime;

        //mathf rounds the decimal numbers to prevent an overflow of #s
        Timer.text = "Time Remaining :" + Mathf.Round(timeRemaining);

    }
}
