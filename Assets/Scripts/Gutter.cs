using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gutter : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnTriggerEnter(Collider other)
    {
        // Check if the tag of the object that entered the gutter is a ball. If it is, the player lost
        if(other.gameObject.tag == "Ball")
        {
            SceneManager.LoadScene("LoseScene");
        }
    }
}
