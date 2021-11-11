using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField]
    private GameObject coin;

    [SerializeField]
    private GameObject cookieCanvas;

    [SerializeField]
    private GameObject robotCanvas;

    [SerializeField]
    private GameObject achievementCanvas;

    [SerializeField]
    private Text coinText;

    [SerializeField]
    private Text coinText1;

    [SerializeField]
    private Text coinText2;

    [SerializeField]
    private Text cookieUpgradeText;

    [SerializeField]
    private Text flavourUpgradeText;

    [SerializeField]
    private Text moreRobotsText;

    [SerializeField]
    private Text upgradeRobotsText;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       CoinTextUpdate(); 
       CostTextUpdate();
    }

    public void CookieButton()
    {
        if (robotCanvas.activeSelf == false && achievementCanvas.activeSelf == false)
        {
            coin.SetActive(!coin.activeSelf);
            cookieCanvas.SetActive(!cookieCanvas.activeSelf);
        }
    }

    public void RobotButton()
    {
        if (cookieCanvas.activeSelf == false && achievementCanvas.activeSelf == false)
        {
            coin.SetActive(!coin.activeSelf);
            robotCanvas.SetActive(!robotCanvas.activeSelf);
        }
    }

    public void MainButton()
    {
        GameObject currentMonster = GameObject.FindGameObjectWithTag("Monster");

        currentMonster.GetComponent<Monster>().Clicked();
    }

    public void CookieUpgradeButton()
    {
        if (gVar.gold >= gVar.cookieCost)
        {
            gVar.gold -= gVar.cookieCost;
            PlayerPrefs.SetFloat("gold", gVar.gold);

            gVar.cookieSize += 1;
            PlayerPrefs.SetFloat("cookieSize", gVar.cookieSize);

            gVar.cookieCost = 10 * gVar.cookieSize;
            PlayerPrefs.SetFloat("cookieCost", gVar.cookieCost);
        }
    }

    public void FlavourUpgradeButton()
    {
        if (gVar.gold >= gVar.flavourCost)
        {
            gVar.gold -= gVar.flavourCost;
            PlayerPrefs.SetFloat("gold", gVar.gold);

            gVar.cookieFlavours += 0.2f;
            PlayerPrefs.SetFloat("cookieFlavours", gVar.cookieFlavours);

            gVar.flavourCost = 20 * gVar.cookieFlavours;
            PlayerPrefs.SetFloat("flavourCost", gVar.flavourCost);
        }
    }

    public void MoreRobotsButton()
    {
        if (gVar.gold >= gVar.robotCost)
        {
            gVar.gold -= gVar.robotCost;
            PlayerPrefs.SetFloat("gold", gVar.gold);

            gVar.robotArmy += 1;
            PlayerPrefs.SetFloat("robotArmy", gVar.robotArmy);

            gVar.robotCost = 10 * gVar.robotArmy;
            PlayerPrefs.SetFloat("robotCost", gVar.robotCost);
        }
    }

    public void UpgradeRobotsButton()
    {
        if (gVar.gold >= gVar.upgradeCost)
        {
            gVar.gold -= gVar.upgradeCost;
            PlayerPrefs.SetFloat("gold", gVar.gold);

            gVar.robotLvl += 0.2f;
            PlayerPrefs.SetFloat("robotLvl", gVar.robotLvl);

            gVar.upgradeCost = 20 * gVar.robotLvl;
            PlayerPrefs.SetFloat("upgradeCost", gVar.upgradeCost);
        }
    }

    public void AchievementButton()
    {
        if (robotCanvas.activeSelf == false && cookieCanvas.activeSelf == false)
        {
            coin.SetActive(!coin.activeSelf);
            achievementCanvas.SetActive(!achievementCanvas.activeSelf);
        }
    }
    
    public void BirdButton()
    {
        gVar.gold += 30 * gVar.cookieSize;
        PlayerPrefs.SetFloat("gold", gVar.gold);
    }

    public void CoinTextUpdate()
    {
        coinText.text = gVar.gold.ToString("N0");
        coinText1.text = gVar.gold.ToString("N0");
        coinText2.text = gVar.gold.ToString("N0");
    }

    public void CostTextUpdate()
    {
        cookieUpgradeText.text = gVar.cookieCost.ToString("N0");
        flavourUpgradeText.text = gVar.flavourCost.ToString("N0");
        moreRobotsText.text = gVar.robotCost.ToString("N0");
        upgradeRobotsText.text = gVar.upgradeCost.ToString("N0");
    }
}
