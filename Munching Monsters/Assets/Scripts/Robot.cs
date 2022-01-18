using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{
    // Get a reference to the GameObject of the current monster
    public GameObject currentMonster;

    // Start is called before the first frame update
    void Start()
    {
        // Start the coroutine which works as the robot
        StartCoroutine(RobotClick());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // This coroutine will run every second on a loop while the game is running
    public IEnumerator RobotClick()
    {
        // Wait for 1 second
        yield return new WaitForSeconds(1);

        // Set the current monster GameObject
        currentMonster = GameObject.FindGameObjectWithTag("Monster");

        // If the monster exists and the robot level is greater than 0, then call the RobotClicked() function
        if (currentMonster != null && gVar.robotLvl != 0)
        {
            currentMonster.GetComponent<Monster>().RobotClicked();
        }

        // Set the current monster GameObject to null
        currentMonster = null;

        // Call the coroutine again
        StartCoroutine(RobotClick());
    }
}
