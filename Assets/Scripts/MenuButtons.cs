using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        // Show the cursor and unlock it from being stuck in the middle of the screen
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
	
	// Update is called once per frame
	void Update ()
    {
        
    }

    public void StartClick()
    {
        // Load the bowling scene when "Start Game" button is clicked
        SceneManager.LoadScene("Bowling");
    }

    public void QuitClick()
    {
        // Quit the game when "Quit Game" button is clicked
        Application.Quit();
    }

    public void MenuClick()
    {
        // Load the main menu scene when "Main Menu" button is clicked
        SceneManager.LoadScene("Menu");
    }
}
