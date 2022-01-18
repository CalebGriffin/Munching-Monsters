using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    // Create an array of GameObjects to store all of the monster objects
    private GameObject[] monsters;

    // Get a reference to the GameObject that controls all of the achievements
    [SerializeField] private GameObject achievementManager;

    // Keeps track of the monster that was spawned previously
    private int previousMonster = -1;

    // Boolean to track whether the next monster has been chosen
    private bool monsterFound = false;

    // Keeps track of the monster that will be spawned next
    private int monsterToBeSpawned = -1;

    // Start is called before the first frame update
    void Start()
    {
        // Find all of the monster GameObjects in the scene and add them to the array
        monsters = GameObject.FindGameObjectsWithTag("Monster");
        // Set all of the monster GameObjects to inactive
        foreach (GameObject monster in monsters)
        {
            monster.SetActive(false);
        }

        // Start the coroutine which will spawn the first monster
        StartCoroutine(Wait());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Wait for a short amount of time and spawn a monster
    public IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.1f);
        SpawnMonster();
    }

    // This is called each time a monster is fed to spawn a new monster
    public void SpawnMonster()
    {
        // Set all of the monsters to inactive
        foreach (GameObject monster in monsters)
        {
            monster.SetActive(false);
        }

        // While the next monster has not been chosen
        while (monsterFound == false)
        {
            // Pick a random number between 0 and the number of monsters there are in the game
            monsterToBeSpawned = Random.Range(0, monsters.Length);

            // If the selected monster is not the same as the previous monster, then set the previous monster to the new monster and set the boolean to true
            if (monsterToBeSpawned != previousMonster)
            {
                previousMonster = monsterToBeSpawned;
                monsterFound = true;
            }
        }

        // Set the monster found boolean to false
        monsterFound = false;

        // Set the selected monster GameObject to active
        monsters[monsterToBeSpawned].SetActive(true);

        // Increase the 2 variables that store how many monsters have been spawned
        gVar.monstersSpawned += 1;
        gVar.totalMonstersSpawned += 1;

        // Save the variables to the PlayerPrefs
        PlayerPrefs.SetInt("monstersSpawned", gVar.monstersSpawned);
        PlayerPrefs.SetInt("totalMonstersSpawned", gVar.totalMonstersSpawned);

        // Run the function that will check if any of the achievements have been completed
        AchievementChecker();

        // REMEMBER TO REMOVE
        Debug.Log("Monsters Spawned: " + gVar.monstersSpawned.ToString());

        // Every 5 monsters that are spawned, increase the level of the monsters
        if (gVar.monstersSpawned >= 5)
        {
            gVar.monsterLvl += 2;
            PlayerPrefs.SetInt("monsterLvl", gVar.monsterLvl);
            Debug.Log("Monster Level: " + gVar.monsterLvl.ToString());

            gVar.monstersSpawned = 0;
            PlayerPrefs.SetInt("monstersSpawned", gVar.monstersSpawned);
        }
    }

    // This function checks if any of the achievements have been completed
    public void AchievementChecker()
    {
        switch (gVar.totalMonstersSpawned)
        {
            case 10:
                achievementManager.GetComponent<AchievementManager>().EarnAchievement("Beginner Feeder");
                break;

            case 20:
                achievementManager.GetComponent<AchievementManager>().EarnAchievement("Amateur Feeder");
                break;

            case 50:
                achievementManager.GetComponent<AchievementManager>().EarnAchievement("Intermediate Feeder");
                break;

            case 100:
                achievementManager.GetComponent<AchievementManager>().EarnAchievement("Professional Feeder");
                break;

            case 200:
                achievementManager.GetComponent<AchievementManager>().EarnAchievement("Expert Feeder");
                break;

            case 500:
                achievementManager.GetComponent<AchievementManager>().EarnAchievement("Master Feeder");
                break;

            default:
                break;
        }
    }
}