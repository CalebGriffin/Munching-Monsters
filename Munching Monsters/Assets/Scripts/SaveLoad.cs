using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       // REMEMBER TO REMOVE
       PlayerPrefs.DeleteAll();

       gVar.cookieSize = PlayerPrefs.GetInt("cookieSize", 1); 
       gVar.cookieFlavours = PlayerPrefs.GetInt("cookieFlavours", 1); 
       gVar.robotArmy = PlayerPrefs.GetInt("robotArmy", 0); 
       gVar.robotLvl = PlayerPrefs.GetInt("robotLvl", 1); 
       gVar.monsterLvl = PlayerPrefs.GetInt("monsterLvl", 1); 
       gVar.gold = PlayerPrefs.GetInt("gold", 0);
       gVar.monstersSpawned = PlayerPrefs.GetInt("monstersSpawned", 0);
       gVar.cookieCost = PlayerPrefs.GetInt("cookieCost", 10 * gVar.cookieSize);
       gVar.flavourCost = PlayerPrefs.GetInt("flavourCost", 20 * gVar.cookieFlavours);
       gVar.robotCost = PlayerPrefs.GetInt("robotCost", 10 * gVar.robotArmy);
       gVar.upgradeCost = PlayerPrefs.GetInt("upgradeCost", 20 * gVar.robotLvl);
    }

    // Update is called once per frame
    void Update()
    {
       //PlayerPrefs.SetInt("cookieSize", gVar.cookieSize); 
       //PlayerPrefs.SetInt("cookieFlavours", gVar.cookieFlavours); 
       //PlayerPrefs.SetInt("robotArmy", gVar.robotArmy); 
       //PlayerPrefs.SetInt("robotLvl", gVar.robotLvl); 
       //PlayerPrefs.SetInt("monsterLvl", gVar.monsterLvl); 
    }
}
