using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarScript : MonoBehaviour
{
    // These are the variables that will be used within this script
    [SerializeField]
    private int fillAmount;

    [SerializeField]
    private float lerpSpeed;

    [SerializeField]
    private Slider content;

    [SerializeField]
    private Text valueText;

    private float timeElapsed = 0;

    // This is a public property for the maximum value that the bar can have, it can be accessed by other scripts
    public int MaxValue
    {   
        set
        {
            content.maxValue = value;
        }
    
    }

    // This is a public property for the value of the bar, it can be accessed by other scripts
    public int Value
    {
        set
        {
            // This will take the text that is supplied and remove anything before the colon and update the value
            string[] tmp = valueText.text.Split(':');
            fillAmount = value;
            valueText.text = tmp[0] + ": " + fillAmount.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        HandleBar();
    }

    // HandleBar is run once every frame because it is called by Update
    // It will update the value of the UI bar based on the code
    private void HandleBar()
    {
        // If the current value of the bar is not the same as the UI bar then update it by lerping the value
        if (fillAmount != content.value)
        {
            if (timeElapsed < lerpSpeed)
            {
                content.value = Mathf.Lerp(content.value, fillAmount, timeElapsed / lerpSpeed);
                timeElapsed += Time.deltaTime;
            }
            else
            {
                timeElapsed = 0;
            }
        }
    }
}
