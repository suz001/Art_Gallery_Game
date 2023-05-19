using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimeManag : MonoBehaviour,IdDataPersistence
{
    public static Action OnMinuteChanged;
    public static Action OnHourChanged;

    public static int Minute {get; private set;}
    public static int Hour {get; private set;}

    private float minuteToRealTime = 0.005f;
    private float timer;

    void Start(){
        Minute = 0;
        Hour = 6;
        timer = minuteToRealTime;
    }
    void Update(){
        timer -= Time.deltaTime;
        if(timer <=0){
            Minute++;
            OnMinuteChanged?.Invoke();
            if(Minute>=60){
                if(Hour>=21){
                    Hour = 6;
                }
                else{
                    Hour++;
                }
                Minute = 0;
                OnHourChanged?.Invoke();
            }
            timer = minuteToRealTime;
        }

    }
    public void LoadData(GameData data){

        TimeManag.Minute = data.Minute;
        TimeManag.Hour = data.Hour;
    }
    public void SaveData(ref GameData data){
        data.Minute=TimeManag.Minute;
        data.Hour=TimeManag.Hour;
    }
    
}