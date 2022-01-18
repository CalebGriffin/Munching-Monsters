using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    // A reference to the coin GameObject so that it can be hidden and shown by the UI elements
    [SerializeField]
    private GameObject coin;

    // A reference to the canvas that contains all of the cookie upgrade UI
    [SerializeField]
    private GameObject cookieCanvas;

    // A reference to the canvas that contains all of the robot upgrade UI
    [SerializeField]
    private GameObject robotCanvas;

    // A reference to the canvas that contains all of the achievement UI
    [SerializeField]
    private GameObject achievementCanvas;

    // A reference to the Text UI that shows the amount of gold the player has
    [SerializeField]
    private Text coinText;

    // A reference to the Text UI that shows the amount of gold the player has
    [SerializeField]
    private Text coinText1;

    // A reference to the Text UI that shows the amount of gold the player has
    [SerializeField]
    private Text coinText2;

    // A reference to the Text UI that shows the cost of a cookie upgrade
    [SerializeField]
    private Text cookieUpgradeText;

    // A reference to the Text UI that shows the cost of a cookie upgrade
    [SerializeField]
    private Text flavourUpgradeText;

    // A reference to the Text UI that shows the cost of a robot upgrade
    [SerializeField]
    private Text moreRobotsText;

    // A reference to the Text UI that shows the cost of a robot upgrade
    [SerializeField]
    private Text upgradeRobotsText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Run the 2 functions that update the game's UI
        CoinTextUpdate(); 
        CostTextUpdate();
    }

    // This function will be called every time the cookie button is clicked
    public void CookieButton()
    {
        // If no other UI elements are active, then toggle the default coin UI and toggle the cookie canvas UI
        if (robotCanvas.activeSelf == false && achievementCanvas.activeSelf == false)
        {
            coin.SetActive(!coin.activeSelf);
            cookieCanvas.SetActive(!cookieCanvas.activeSelf);
        }
    }

    // This function will be called every time the robot button is clicked
    public void RobotButton()
    {
        // If no other UI elements are active, then toggle the default coin UI and toggle the robot canvas UI
        if (cookieCanvas.activeSelf == false && achievementCanvas.activeSelf == false)
        {
            coin.SetActive(!coin.activeSelf);
            robotCanvas.SetActive(!robotCanvas.activeSelf);
        }
    }

    // This function will be called every time the monster is clicked
    public void MainButton()
    {
        // Find the current monster in the scene
        GameObject currentMonster = GameObject.FindGameObjectWithTag("Monster");

        // Call the function on the monster so it knows that it has been clicked
        currentMonster.GetComponent<Monster>().Clicked();
    }

    // This function will be called every time the cookie upgrade button is clicked
    public void CookieUpgradeButton()
    {
        // If the player has enough gold to afford the upgrade
        if (gVar.gold >= gVar.cookieCost)
        {
            // Minus the cost from the total gold and save
            gVar.gold -= gVar.cookieCost;
            PlayerPrefs.SetFloat("gold", gVar.gold);

            // Increase the cookie variable and save
            gVar.cookieSize += 1;
            PlayerPrefs.SetFloat("cookieSize", gVar.cookieSize);

            // Increase the cost of the cookie upgrade and save
            gVar.cookieCost = 10 * gVar.cookieSize;
            PlayerPrefs.SetFloat("cookieCost", gVar.cookieCost);
        }
    }

    // This function will be called every time the cookie upgrade button is clicked
    public void FlavourUpgradeButton()
    {
        // If the player has enough gold to afford the upgrade
        if (gVar.gold >= gVar.flavourCost)
        {
            // Minus the cost from the total gold and save
            gVar.gold -= gVar.flavourCost;
            PlayerPrefs.SetFloat("gold", gVar.gold);

            // Increase the cookie variable and save
            gVar.cookieFlavours += 0.2f;
            PlayerPrefs.SetFloat("cookieFlavours", gVar.cookieFlavours);

            // Increase the cost of the cookie upgrade and save
            gVar.flavourCost = 20 * gVar.cookieFlavours;
            PlayerPrefs.SetFloat("flavourCost", gVar.flavourCost);
        }
    }

    // This function will be called every time the robot upgrade button is clicked
    public void MoreRobotsButton()
    {
        // If the player has enough gold to afford the upgrade
        if (gVar.gold >= gVar.robotCost)
        {
            // Minus the cost from the total gold and save
            gVar.gold -= gVar.robotCost;
            PlayerPrefs.SetFloat("gold", gVar.gold);

            // Increase the robot variable and save
            gVar.robotArmy += 1;
            PlayerPrefs.SetFloat("robotArmy", gVar.robotArmy);

            // Increase the cost of the robot upgrade and save
            gVar.robotCost = 10 * gVar.robotArmy;
            PlayerPrefs.SetFloat("robotCost", gVar.robotCost);
        }
    }

    // This function will be called every time the robot upgrade button is clicked
    public void UpgradeRobotsButton()
    {
        // If the player has enough gold to afford the upgrade
        if (gVar.gold >= gVar.upgradeCost)
        {
            // Minus the cost from the total gold and save
            gVar.gold -= gVar.upgradeCost;
            PlayerPrefs.SetFloat("gold", gVar.gold);

            // Increase the robot variable and save
            gVar.robotLvl += 0.2f;
            PlayerPrefs.SetFloat("robotLvl", gVar.robotLvl);

            // Increase the cost of the robot upgrade and save
            gVar.upgradeCost = 20 * gVar.robotLvl;
            PlayerPrefs.SetFloat("upgradeCost", gVar.upgradeCost);
        }
    }

    // This function will be called every time the achievement button is clicked
    public void AchievementButton()
    {
        // If no other UI elements are active, then toggle the default coin UI and toggle the achievement canvas UI
        if (robotCanvas.activeSelf == false && cookieCanvas.activeSelf == false)
        {
            coin.SetActive(!coin.activeSelf);
            achievementCanvas.SetActive(!achievementCanvas.activeSelf);
        }
    }
    
    // This function will be called every time the bird with a cookie is clicked
    public void BirdButton()
    {
        // Increase the player's gold by the current cookie variable multiplied by 30 and save
        gVar.gold += 30 * gVar.cookieSize;
        PlayerPrefs.SetFloat("gold", gVar.gold);
    }

    // This function will update the UI to show the amount of gold that the player currently has
    public void CoinTextUpdate()
    {
        // Set the text of each Text object to the gold variable converted to a string with a format that includes commas and 2 decimal places
        coinText.text = gVar.gold.ToString("N0");
        coinText1.text = gVar.gold.ToString("N0");
        coinText2.text = gVar.gold.ToString("N0");
    }

    public void CostTextUpdate()
    {
        // Set the text of each Text object to the cost variable converted to a string with a format that includes commas and 2 decimal places
        cookieUpgradeText.text = gVar.cookieCost.ToString("N0");
        flavourUpgradeText.text = gVar.flavourCost.ToString("N0");
        moreRobotsText.text = gVar.robotCost.ToString("N0");
        upgradeRobotsText.text = gVar.upgradeCost.ToString("N0");
    }
}