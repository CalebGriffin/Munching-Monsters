using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    // Create an instance of the Stat class called hunger
    [SerializeField]
    private Stat hunger;

    // Get a reference to the GameObject that spawns monsters
    public GameObject MonsterSpawner;

    // Start is called before the first frame update
    void Start()
    {
    }

    // OnEnable is called when the object is set to active
    void OnEnable()
    {
        // Call the initialize function on the Stat class to set the values of the hunger bar
        hunger.Initialize();
        // Set the hunger bar to empty
        hunger.CurrentVal = 0;
        // Set the maximum value of the hunger bar to the monster level multiplied by 10
        hunger.MaxVal = 10 * gVar.monsterLvl;
    }

    // Update is called once per frame
    void Update()
    {
        // REMEMBER TO REMOVE
        // This is for testing purposes to show the hunger bar working but wouldn't run in the actual game because it's a mobile build
        if (Input.GetKeyDown(KeyCode.A))
        {
            hunger.CurrentVal -= 1;
        } 
        if (Input.GetKeyDown(KeyCode.R))
        {
            hunger.CurrentVal += 1;
        } 

        // If the hunger bar is full, then start the coroutine to despawn the monster
        if (hunger.CurrentVal == hunger.MaxVal)
        {
            StartCoroutine(Fed());
        }
    }

    // This coroutine is called when the monster has been fed and it's hunger bar is full
    private IEnumerator Fed()
    {
        // Wait for a very small amount of time to prevent a bug that caused the monsters to instantly despawn
        yield return new WaitForSeconds(0.1f);

        // Increase the player's gold by the monster's level multiplied by 10
        gVar.gold += 10 * gVar.monsterLvl;
        // Save the Player's amount of gold
        PlayerPrefs.SetFloat("gold", gVar.gold);
        // Set the hunger bar back to zero
        hunger.CurrentVal = 0;
        // Call the function to spawn another monster on the Monster Spawner GameObject
        MonsterSpawner.GetComponent<MonsterSpawner>().SpawnMonster();
    }

    // This function will be run when the player clicks on the monster
    public void Clicked()
    {
        // Increase the hunger bar value by the different cookie upgrade values multiplied together
        hunger.CurrentVal += gVar.cookieSize * gVar.cookieFlavours;
    }

    // This function will be called by the robot script every second
    public void RobotClicked()
    {
        // Increase the hunger bar value by the different robot upgrade values multiplied together
        hunger.CurrentVal += (gVar.robotArmy - 1) * gVar.robotLvl;
    }
}