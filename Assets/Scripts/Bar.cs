﻿using System;
using UnityEngine;
using UnityEngine.UI;

public class Bar : MonoBehaviour
{

    [SerializeField]
    private bool lerpColors;

    [SerializeField]
    private Image content;


    [SerializeField]
    private Text valueText;


    [SerializeField]
    private float lerpSpeed;

   
    private float fillAmount;


    [SerializeField]
    private Color fullColor;


    [SerializeField]
    private Color lowColor;

    
    public float MaxValue { get; set; }

    
    public float Value
    {
        set
        {
            string[] tmp = valueText.text.Split(':');

            valueText.text = tmp[0] + ": " + value;

            fillAmount = Map(value, 0, MaxValue, 0, 1);
        }
    }

    void Start()
    {
        if (lerpColors)
        {
            content.color = fullColor;
        }
    }

    
    void Update()
    {
        
        HandleBar();

    }

    
    private void HandleBar()
    {
        if (fillAmount != content.fillAmount) 
        {

            content.fillAmount = Mathf.Lerp(content.fillAmount, fillAmount, Time.deltaTime * lerpSpeed);

            if (lerpColors) 
            {
                
                content.color = Color.Lerp(lowColor, fullColor, fillAmount);
            }

        }
    }

    private float Map(float value, float inMin, float inMax, float outMin, float outMax)
    {
        return (value - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
    }
}