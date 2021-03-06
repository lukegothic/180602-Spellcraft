﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public static GameManager instance = null;              //Static instance of GameManager which allows it to be accessed by any other script.

    // Use this for initialization
    //Awake is always called before any Start functions
    void Awake() {
        //Check if instance already exists
        if (instance == null) {
            //if not, set instance to this
            instance = this;
        }
        //If instance already exists and it's not this:
        else if (instance != this) {
            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);
        }

        //Sets this to not be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);

        ////Assign enemies to a new List of Enemy objects.
        //enemies = new List<Enemy>();

        ////Get a component reference to the attached BoardManager script
        //boardScript = GetComponent<BoardManager>();

        ////Call the InitGame function to initialize the first level 
        //InitGame();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
