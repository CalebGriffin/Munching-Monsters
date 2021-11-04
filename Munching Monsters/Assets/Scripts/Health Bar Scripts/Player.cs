using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Creates an attribute for the player called Health which will be reflected as a health bar
    [SerializeField]
    private Stat health;

    // In the frame before the games starts this will call the function to set the initial variables for the health bar
    private void Awake()
    {
        health.Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        // When the player presses down the A and R keys, the health will go up and down
        if (Input.GetKeyDown(KeyCode.A))
        {
            health.CurrentVal -= 10;
        } 

        if (Input.GetKeyDown(KeyCode.R))
        {
            health.CurrentVal += 10;
        } 
    }
}
