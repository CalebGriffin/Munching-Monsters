using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private float speed = 2;

    // Update is called once per frame
    void Update()
    {
       transform.Translate(Vector3.left * speed * Time.deltaTime); 
    }

    void OnBecameInvisible()
    {
        this.gameObject.SetActive(false);
    }
}
