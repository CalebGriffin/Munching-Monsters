using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
   // Start is called before the first frame update
   void Start()
   {
      // REMEMBER TO REMOVE
      // Deletes all of the Player Prefs
      PlayerPrefs.DeleteAll();

      // Sets up all of the different global variables when the game starts
      gVar.cookieSize = PlayerPrefs.GetFloat("cookieSize", 1); 
      gVar.cookieFlavours = PlayerPrefs.GetFloat("cookieFlavours", 1); 
      gVar.robotArmy = PlayerPrefs.GetFloat("robotArmy", 1); 
      gVar.robotLvl = PlayerPrefs.GetInt("robotLvl", 1); 
      gVar.monsterLvl = PlayerPrefs.GetInt("monsterLvl", 1); 
      gVar.gold = PlayerPrefs.GetFloat("gold", 0);
      gVar.monstersSpawned = PlayerPrefs.GetInt("monstersSpawned", 0);
      gVar.cookieCost = PlayerPrefs.GetFloat("cookieCost", 10 * gVar.cookieSize);
      gVar.flavourCost = PlayerPrefs.GetFloat("flavourCost", 20 * gVar.cookieFlavours);
      gVar.robotCost = PlayerPrefs.GetFloat("robotCost", 10 * gVar.robotArmy);
      gVar.upgradeCost = PlayerPrefs.GetFloat("upgradeCost", 20 * gVar.robotLvl);
      gVar.totalMonstersSpawned = PlayerPrefs.GetInt("totalMonstersSpawned", 0);
   }

   // Update is called once per frame
   void Update()
   {
      // NOT IN USE
      // This would have updated some of the variables every frame but this was not efficient
      //PlayerPrefs.SetInt("cookieSize", gVar.cookieSize); 
      //PlayerPrefs.SetInt("cookieFlavours", gVar.cookieFlavours); 
      //PlayerPrefs.SetInt("robotArmy", gVar.robotArmy); 
      //PlayerPrefs.SetInt("robotLvl", gVar.robotLvl); 
      //PlayerPrefs.SetInt("monsterLvl", gVar.monsterLvl); 
   }
}