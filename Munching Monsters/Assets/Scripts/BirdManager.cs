using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdManager : MonoBehaviour
{
    [SerializeField]
    private GameObject bird;

    [SerializeField]
    private GameObject birdWithCookie;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnBird());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator SpawnBird()
    {
        float waitTime = Random.Range(5.0f,7.0f);

        int birdRand = Random.Range(1, 10);

        yield return new WaitForSeconds(waitTime);

        if (birdRand == 10)
        {
            if (birdWithCookie.activeSelf == false)
            {
                birdWithCookie.transform.position = new Vector3(4, Random.Range(3.0f, 4.2f), 0);
                birdWithCookie.SetActive(true);
            }
        }
        else
        {
            if (bird.activeSelf == false)
            {
                bird.transform.position = new Vector3(4, Random.Range(3.0f, 4.2f), 0);
                bird.SetActive(true);
            }
        }

        StartCoroutine(SpawnBird());
    }
}
