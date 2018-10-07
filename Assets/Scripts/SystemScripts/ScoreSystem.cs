using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem: MonoBehaviour {

    Text score;  
    public static int scoreValue = 0;
    public static float multiplier = 1;
    

	// Use this for initialization
	void Start () {
        score = GetComponent<Text>();

	}
	
	// Update is called once per frame
	void Update () {
        //scorevalue is called upon in the LiveSystem(line 110) to give the integer a value. 

        score.text = "Score: " + scoreValue * multiplier;
        //multipler is called upon in the livesystem as well to give it a value. 
       
		
	}
}
