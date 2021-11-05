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
    private Text coinText;

    [SerializeField]
    private Text coinText1;

    [SerializeField]
    private Text coinText2;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       CoinTextUpdate(); 
    }

    public void CookieButton()
    {
        if (robotCanvas.activeSelf == false)
        {
            coin.SetActive(!coin.activeSelf);
            cookieCanvas.SetActive(!cookieCanvas.activeSelf);
        }
    }

    public void RobotButton()
    {
        if (cookieCanvas.activeSelf == false)
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

    }

    public void FlavourUpgradeButton()
    {

    }

    public void MoreRobotsButton()
    {

    }

    public void UpgradeRobotsButton()
    {

    }

    public void AchievementButton()
    {

    }
    
    public void BirdButton()
    {
        gVar.gold += 20 * gVar.cookieSize;
        PlayerPrefs.SetInt("gold", gVar.gold);
    }

    public void CoinTextUpdate()
    {
        coinText.text = gVar.gold.ToString();
        coinText1.text = gVar.gold.ToString();
        coinText2.text = gVar.gold.ToString();
    }
}
