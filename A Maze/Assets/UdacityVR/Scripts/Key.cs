using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
    public GameObject key;
    public Door door;
    public GameObject keyPoof;

    private bool keyCollected;

    void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
	}

	public void OnKeyClicked()
	{

        AudioSource audio = key.GetComponent<AudioSource>();
        audio.Play();
        // Instantiate the KeyPoof Prefab where this key is located
        Object.Instantiate(keyPoof, transform.position, Quaternion.identity);
        // Call the Unlock() method on the Door
        door.Unlock();
        Debug.Log("Door should be unlocked now.");
        // Set the Key Collected Variable to true
        keyCollected = true;
        // Destroy the key. Check the Unity documentation on how to use Destroy
        DestroyGameObject();
    }

    void DestroyGameObject()
    {
        Destroy(gameObject);
    }

}
