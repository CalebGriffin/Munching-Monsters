using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdManager : MonoBehaviour
{
    // Get a reference to the normal bird object
    [SerializeField]
    private GameObject bird;

    // Get a reference to the bird with a cookie object
    [SerializeField]
    private GameObject birdWithCookie;

    // Start is called before the first frame update
    void Start()
    {
        // Start a coroutine that spawns one of the 2 bird objects every few seconds
        StartCoroutine(SpawnBird());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // The coroutine that spawns the bird objects
    private IEnumerator SpawnBird()
    {
        // Sets the amount of time that it should wait to a random number between 5 and 7
        float waitTime = Random.Range(5.0f,7.0f);

        // Pick a random number between 1 and 10
        int birdRand = Random.Range(1, 10);

        // Wait for the amount of time generated above
        yield return new WaitForSeconds(waitTime);

        // If the random number was 1, then spawn a bird with a cookie, otherwise, spawn a normal bird
        if (birdRand == 1)
        {
            // If the bird with a cookie object is not active, then set the start position of the bird object and activate it
            if (birdWithCookie.activeSelf == false)
            {
                birdWithCookie.transform.position = new Vector3(4, Random.Range(3.0f, 4.2f), 0);
                birdWithCookie.SetActive(true);
            }
        }
        else
        {
            // If the bird object is not active, then set the start position of the bird object and activate it
            if (bird.activeSelf == false)
            {
                bird.transform.position = new Vector3(4, Random.Range(3.0f, 4.2f), 0);
                bird.SetActive(true);
            }
        }

        // Call the coroutine again
        StartCoroutine(SpawnBird());
    }
}