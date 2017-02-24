using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

[Serializable]
public class Stat
{
  
    [SerializeField]
    private Bar bar;

  
    [SerializeField]
    private float maxVal;

 
    [SerializeField]
    private float currentVal;

   
    public float CurrentValue
    {
        get
        {
            return currentVal;
        }
        set
        {
            
            this.currentVal = Mathf.Clamp(value, 0, MaxVal);

            //Updates the bar
            bar.Value = currentVal;
        }
    }

    
    public float MaxVal
    {
        get
        {
            return maxVal;
        }
        set
        {
            //Updates the bar's max value
            bar.MaxValue = value;

            //Sets the max value
            this.maxVal = value;
        }
    }

 
    public void Initialize()
    {
        //Updates the bar
        this.MaxVal = maxVal;
        this.CurrentValue = currentVal;
    }
}