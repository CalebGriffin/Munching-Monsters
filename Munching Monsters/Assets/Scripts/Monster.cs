﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [SerializeField]
    private Stat hunger;

    public GameObject MonsterSpawner;

    // Start is called before the first frame update
    void Start()
    {
    }

    void Awake()
    {
        hunger.Initialize();
        hunger.CurrentVal = 0;
        Debug.Log(gVar.monsterLvl.ToString());
        hunger.MaxVal = 10 * gVar.monsterLvl;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            hunger.CurrentVal -= 1;
        } 

        if (Input.GetKeyDown(KeyCode.R))
        {
            hunger.CurrentVal += 1;
        } 

        if (hunger.CurrentVal == hunger.MaxVal)
        {
            StartCoroutine(Fed());
        }
    }

    private IEnumerator Fed()
    {
        yield return new WaitForSeconds(0.2f);

        gVar.gold += 10 * gVar.monsterLvl;
        PlayerPrefs.SetInt("gold", gVar.gold);
        hunger.CurrentVal = 0;
        MonsterSpawner.GetComponent<MonsterSpawner>().SpawnMonster();
    }

    public void Clicked()
    {
        hunger.CurrentVal += gVar.cookieSize * gVar.cookieFlavours;
    }
}
