using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This class is public so that it can be accessed by all of the other scripts
public class gVar 
{
    // This is used to keep track of the number of cookie upgrades the player has bought
    public static float cookieSize;

    // This is used to keep track of the number of cookie upgrades the player has bought
    public static float cookieFlavours;

    // This is used to keep track of the number of robot upgrades the player has bought
    public static float robotArmy;

    // This is used to keep track of the number of robot upgrades the player has bought
    public static float robotLvl;

    // This is used to keep track of the level of the monsters meaning how many cookie they need to be fed
    public static int monsterLvl = 1;

    // This is used to keep track of how much gold the player has
    public static float gold;

    // This is used to temporarily track how many monsters have been spawned to increase monster level every 5 monsters
    public static int monstersSpawned;

    // This is used to keep track of the of the cookie upgrades
    public static float cookieCost;

    // This is used to keep track of the of the cookie upgrades
    public static float flavourCost;

    // This is used to keep track of the of the robot upgrades
    public static float robotCost;

    // This is used to keep track of the of the robot upgrades
    public static float upgradeCost;

    // This is used to keep track of how many monsters have been spanwed overall for the achievements
    public static int totalMonstersSpawned;
}
