using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    // A float to control the speed that the bird moves at
    private float speed = 2;

    // Update is called once per frame
    void Update()
    {
        // While the bird is active then every frame move it towards the left by the speed variable based on the framerate
        transform.Translate(Vector3.left * speed * Time.deltaTime); 
    }

    // When the object becomes invisible (meaning it can't be seen by the camera), then set the object to inactive
    void OnBecameInvisible()
    {
        this.gameObject.SetActive(false);
    }
}