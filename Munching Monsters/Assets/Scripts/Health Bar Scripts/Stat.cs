using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Stat
{
    // Creates an instance of BarScript called bar that can be referenced later on
    [SerializeField]
    private BarScript bar;

    // Creates a variable to store the maximum value of the bar
    [SerializeField]
    private int maxVal;

    // This is a public property relating to the maximum value of the bar and can be accessed by other scripts
    public int MaxVal
    {
        get
        {
            return maxVal;
        }

        set
        {
            // Sets the UI bar to the maximum value of the bar
            this.maxVal = value;
            bar.MaxValue = maxVal;
        }
    }

    // Creates a variable to store the current value of the bar
    [SerializeField]
    private int currentVal;

    // This is a public property relating to the current value of the bar and can be accessed by other scripts
    public int CurrentVal
    {
        get
        {
            return currentVal;
        }

        set
        {
            // Sets the current value of the bar by clamping it between 0 and the maximum value and then updates the UI bar
            this.currentVal = Mathf.Clamp(value, 0, MaxVal);
            bar.Value = currentVal;
        }
    }

    // This function is used to set up the initial variables for the bar, it is called by another script
    public void Initialize()
    {
        this.MaxVal = maxVal;
        this.CurrentVal = currentVal;
    }
}