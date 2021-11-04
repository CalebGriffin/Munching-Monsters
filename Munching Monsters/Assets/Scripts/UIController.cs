using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField]
    private GameObject coin;

    [SerializeField]
    private GameObject cookieCanvas;

    [SerializeField]
    private GameObject robotCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CookieButton()
    {
        coin.SetActive(!coin.activeSelf);
        cookieCanvas.SetActive(!cookieCanvas.activeSelf);
    }

    public void RobotButton()
    {
        coin.SetActive(!coin.activeSelf);
        robotCanvas.SetActive(!robotCanvas.activeSelf);
    }
}
