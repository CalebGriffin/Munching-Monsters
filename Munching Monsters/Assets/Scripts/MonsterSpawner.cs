using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    private GameObject[] monsters;

    // Start is called before the first frame update
    void Start()
    {
        monsters = GameObject.FindGameObjectsWithTag("Monster");
        foreach (GameObject monster in monsters)
        {
            monster.SetActive(false);
        }

        SpawnMonster();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnMonster()
    {
        foreach (GameObject monster in monsters)
        {
            monster.SetActive(false);
        }

        int monsterToBeSpawned = Random.Range(1, monsters.Length - 1);

        monsters[monsterToBeSpawned].SetActive(true);
    }
}
