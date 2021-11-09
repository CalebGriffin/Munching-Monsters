using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{
    public GameObject currentMonster;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RobotClick());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator RobotClick()
    {
        yield return new WaitForSeconds(1);

        currentMonster = GameObject.FindGameObjectWithTag("Monster");

        if (currentMonster != null && gVar.robotLvl != 0)
        {
            currentMonster.GetComponent<Monster>().RobotClicked();
        }

        currentMonster = null;

        StartCoroutine(RobotClick());
    }
}
