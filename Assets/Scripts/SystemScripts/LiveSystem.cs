using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LiveSystem : MonoBehaviour {
    
    // calling to open up spots for the health images in the UI.
    public static int health;
    public GameObject heart1, heart2, heart3, heart4, heart5;
    
   // private int counter = 0;

    //set up for timer later this week
    public float currentTimer = 0f;
    public float startingTimer = 100f;

    void Start()
    {
        // currentTimer = startingTimer;
        health = 5;
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
        heart4.gameObject.SetActive(true);
        heart5.gameObject.SetActive(true);
    }

    void Update()
    {
        //currentTimer -= 1 * Time.deltaTime;

        if (health > 5)
            health = 5;

        //this is the lives system. we can add or subtract more lives if needed by simply deleting
        //the corresponding life from the cases.
        switch (health) {

            case 5:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                heart4.gameObject.SetActive(true);
                heart5.gameObject.SetActive(true);
                break;

            case 4:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                heart4.gameObject.SetActive(true);
                heart5.gameObject.SetActive(false);
                break;

            case 3:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                heart4.gameObject.SetActive(false);
                heart5.gameObject.SetActive(false);
                break;
            case 2:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                heart4.gameObject.SetActive(false);
                heart5.gameObject.SetActive(false);
                break;

            case 1:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                heart4.gameObject.SetActive(false);
                heart5.gameObject.SetActive(false);
                break;

            case 0:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                heart4.gameObject.SetActive(false);
                heart5.gameObject.SetActive(false);
                break;
        }

    // left click mouse. can change this to the correct solutions for each list answer.
    // i.e. If(answer1 == true) {give sol();}

        if (Input.GetMouseButtonDown(0)) {
            giveSol();
           
        }
        //right click mouse. 
        if(Input.GetMouseButtonDown(1))
        {
            giveWrong();
        }
    }


    //give sol is the function that will control what happens in the UI for the correct answer. Currently all it does is print a line. 
    // Eventually this will ideally call upon the destruction of the numbers in the list. 
    void giveSol()
    {
         Debug.Log("Correct!");

        //this calls upon the ScoreSystem Script and adds a value for each solution they get correct
        ScoreSystem.scoreValue += 10;

        // [in progress] Multiplier system. 
        // Haven't yet figured out how to add a stacking combo system that also fails
        if(ScoreSystem.scoreValue > 200) // && ScoreSystem.combo1 == true
        {
            ScoreSystem.multiplier = 1.2f;
        }

        if (ScoreSystem.scoreValue > 300) //&& ScoreSystem.combo2 == true
        {
            ScoreSystem.multiplier = 1.4f;
        }

        /* if (streak > 5 < 10)
         {
             ScoreSystem.scoreValue += 20;

         }
         if (streak > 11 < 15)
         {
             ScoreSystem.scoreValue += 50;

         }

         if (streak > 16)
         {
             ScoreSystem.scoreValue += 100;
         }
         else*/
    }

        // this function removes a spaceship life each time the player gets a incorrect solution, currently done by right clicking the mouse
        // if they hit 0 lives, they are taken to the end screen. 
        void giveWrong()
    {
        health -= 1;
        Debug.Log("Trash");

        if(health <= 0)
        {
            SceneManager.LoadScene("EndScreen");
        }
    }
}


       