using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    public GameObject CoinPoof;
    public GameObject coin;
    

    //Create a reference to the CoinPoofPrefab

    public void OnCoinClicked() {
        // Instantiate the CoinPoof Prefab where this coin is located
        // Make sure the poof animates vertically

        // Destroy this coin. Check the Unity documentation on how to use Destroy
        DestroyGameObject();
    }

    void DestroyGameObject()
    {

        Destroy(gameObject);

    }
}
