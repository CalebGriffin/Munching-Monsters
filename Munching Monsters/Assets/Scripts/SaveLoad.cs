using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       gVar.cookieSize = PlayerPrefs.GetInt("cookieSize", 1); 
       gVar.cookieFlavours = PlayerPrefs.GetInt("cookieFlavours", 1); 
       gVar.robotArmy = PlayerPrefs.GetInt("robotArmy", 0); 
       gVar.robotLvl = PlayerPrefs.GetInt("robotLvl", 1); 
       gVar.monsterLvl = PlayerPrefs.GetInt("monsterLvl", 1); 
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
