using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBar : MonoBehaviour
{
    public Slider slider;


    
    

    public void SetMaxLoot(float loot)
    {
        slider.maxValue = loot;
        slider.value = loot;
    }
    public void SetLoot(float loot)
    {
        slider.value -= loot;


    }
    
}
