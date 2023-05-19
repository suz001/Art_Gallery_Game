using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TimeUI : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    private void OnEnable(){
        TimeManag.OnMinuteChanged += UpdateTime;
        TimeManag.OnHourChanged += UpdateTime;

    }
    private void OnDisable(){
        TimeManag.OnMinuteChanged -= UpdateTime;
        TimeManag.OnHourChanged -= UpdateTime;
    }
    private void UpdateTime(){
        timeText.text = $"{TimeManag.Hour:00}:{TimeManag.Minute:00}";
    }
    
}
