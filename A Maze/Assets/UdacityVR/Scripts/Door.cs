using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    private bool doorLocked = true;
    // Create a boolean value called "opening" that can be checked in Update() 
    private bool doorOpening = false;

    void Update() {
        // If the door is opening and it is not fully raised
        if (doorLocked == false & transform.position.y < 7.71f)
        {
            // Animate the door raising up
            transform.Translate(0, 2.5f * Time.deltaTime, 0, Space.World);

        }
    }

    public void OnDoorClicked() {
        // If the door is clicked and unlocked
        if (doorLocked == false) {
            // Set the "opening" boolean to true
            doorOpening = true;
            // (optionally) Else
        } else {
            // Play a sound to indicate the door is locked
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
        }
    }

    public void Unlock()
    {
        // You'll need to set "locked" to false here
        doorLocked = false;
    }
}
