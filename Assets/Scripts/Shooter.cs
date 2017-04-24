using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

    // Variables for the amount of force to apply to a bowling ball
    public float minimumForce;
    public float maximumForce;
    public float forceChargeRate;
    private float currentCharge;

    // Bowling ball prefab
    public GameObject bowlingBall;

    // Reload boolean
    private bool needsToReload = false;

	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        // When the user first starts clicking, reset the current charge to the minimum
		if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            currentCharge = minimumForce;
        }

        // As the user holds the mouse button down, charge up the bowling ball
        if (Input.GetKey(KeyCode.Mouse0))
        {
            // Only charge up the bowling ball if it isn't at maximum value alrady
            if (currentCharge < maximumForce)
            {
                currentCharge += forceChargeRate;
            }
        }

        // When the user lets go of the mouse button, release the bowling ball
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            if (!needsToReload)
            {
                // Spawn in front of the camera (and move it down half a meter)
                Vector3 locationToSpawn = Camera.main.transform.position - new Vector3(0, 0.5F, 0) + Camera.main.transform.forward;
                // Calculate the force to add
                Vector3 forceToAdd = Camera.main.transform.forward * currentCharge;

                // Spawn the object and get the gameobject
                GameObject spawnedBowlingBall = Instantiate(bowlingBall, locationToSpawn, Quaternion.identity);
                // Add force to the bowling ball
                spawnedBowlingBall.GetComponent<Rigidbody>().AddForce(forceToAdd);

                // Make the player reload
                needsToReload = true;
            }
        }

        // Right click to reload
        if(Input.GetKeyDown(KeyCode.Mouse1))
        {
            needsToReload = false;
        }
    }
}
