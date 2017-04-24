using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingBall : MonoBehaviour {
    public float secondsUntilDespawn;

	// Use this for initialization
	void Start ()
    {
        Invoke("Die", secondsUntilDespawn);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void Die ()
    {
        Destroy(gameObject);
    }
}
