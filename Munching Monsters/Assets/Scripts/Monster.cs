using System.Collections;
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

    void OnEnable()
    {
        hunger.Initialize();
        hunger.CurrentVal = 0;
        hunger.MaxVal = 10 * gVar.monsterLvl;
    }

    // Update is called once per frame
    void Update()
    {
        // REMEMBER TO REMOVE
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
        PlayerPrefs.SetFloat("gold", gVar.gold);
        hunger.CurrentVal = 0;
        MonsterSpawner.GetComponent<MonsterSpawner>().SpawnMonster();
    }

    public void Clicked()
    {
        hunger.CurrentVal += gVar.cookieSize * gVar.cookieFlavours;
    }

    public void RobotClicked()
    {
        hunger.CurrentVal += gVar.robotArmy * gVar.robotLvl;
    }
}
