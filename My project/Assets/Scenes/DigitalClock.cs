using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DigitalClock : MonoBehaviour
{
    public TextMeshProUGUI display;

    
    
    private void OnEnable(){

        TimeMan.OnMinuteChanged += UpdateTime;
        TimeMan.OnHourChanged += UpdateTime;
        
    }
    private void OnDisable(){
        TimeMan.OnMinuteChanged -= UpdateTime;
        TimeMan.OnHourChanged -= UpdateTime;
    }
    private void UpdateTime(){
        
        display.text = $"{TimeMan.Hour:00}:{TimeMan.Minute:00}";
        //Debug.Log("time");
    }
}