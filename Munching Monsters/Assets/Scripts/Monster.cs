using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [SerializeField]
    private Stat hunger;

    // Start is called before the first frame update
    void Start()
    {
    }

    void Awake()
    {
        hunger.Initialize();
        hunger.MaxVal = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            hunger.CurrentVal -= 1;
        } 

        if (Input.GetKeyDown(KeyCode.R))
        {
            hunger.CurrentVal += 1;
        } 
    }
}
