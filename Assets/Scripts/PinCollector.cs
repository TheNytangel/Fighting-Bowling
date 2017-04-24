using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinCollector : MonoBehaviour {

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
        // Check if the tag of the object that entered the hole is a pin. If it is, add one to the count of pins in the hole. At 10, player wins
        if (other.gameObject.tag == "Pin")
        {
            GameManager.instance.collectedPins++;
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Check if the tag of the object that exited the hole is a pin. If it is, remove one from the count of pins in the hole
        if (other.gameObject.tag == "Pin")
        {
            GameManager.instance.collectedPins--;
        }
    }
}
