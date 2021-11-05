using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    private GameObject[] monsters;

    private int previousMonster = -1;

    private bool monsterFound = false;

    private int monsterToBeSpawned = -1;

    // Start is called before the first frame update
    void Start()
    {
        monsters = GameObject.FindGameObjectsWithTag("Monster");
        foreach (GameObject monster in monsters)
        {
            monster.SetActive(false);
        }

        StartCoroutine(Wait());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.1f);
        SpawnMonster();
    }

    public void SpawnMonster()
    {
        foreach (GameObject monster in monsters)
        {
            monster.SetActive(false);
        }

        while (monsterFound == false)
        {
            monsterToBeSpawned = Random.Range(0, monsters.Length - 1);

            if (monsterToBeSpawned != previousMonster)
            {
                previousMonster = monsterToBeSpawned;
                monsterFound = true;
            }
        }

        monsterFound = false;

        monsters[monsterToBeSpawned].SetActive(true);

        gVar.monstersSpawned += 1;
        PlayerPrefs.SetInt("monstersSpawned", gVar.monstersSpawned);
        Debug.Log("Monsters Spawned: " + gVar.monstersSpawned.ToString());

        if (gVar.monstersSpawned >= 5)
        {
            gVar.monsterLvl += 2;
            PlayerPrefs.SetInt("monsterLvl", gVar.monsterLvl);
            Debug.Log("Monster Level: " + gVar.monsterLvl.ToString());

            gVar.monstersSpawned = 0;
            PlayerPrefs.SetInt("monstersSpawned", gVar.monstersSpawned);
        }
    }
}
