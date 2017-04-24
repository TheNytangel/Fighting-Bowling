using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public static GameManager instance;

    public int collectedPins;

	// Use this for initialization
	void Start ()
    {
        // Singleton stuff
		if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }

        // Set the current collected pins to 0
        collectedPins = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        // Check if the player has all 10 pins in the hole. If player does, show win screen
		if(collectedPins == 10)
        {
            SceneManager.LoadScene("WinScene");
        }

        // On escape, show main menu
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
	}
}
