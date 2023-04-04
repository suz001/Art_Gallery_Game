using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimeMan : MonoBehaviour,IdDataPersistence
{
    public static Action OnMinuteChanged;
    public static Action OnHourChanged;

    public static int Minute{get;set;}= 0;
    public static int Hour{get;set;}=6;

    private float minuteToRealTime = 0.005f;
    private float timer;
    
    private void Start(){
        //Debug.Log("time");
        
        timer = minuteToRealTime;
    }
    private void Update(){
        //Debug.Log("update");
        timer -= Time.deltaTime;
        if(timer <=0){

            Minute++;
            if(OnMinuteChanged!=null){
                OnMinuteChanged.Invoke();
                //Debug.Log("changed");
            }
            //OnMinuteChanged?.Invoke();
            if(Minute >=60){
                if(Hour>=21){
                    Hour=6;
                }
                else{
                    Hour++;
                }
                Minute=0;
                OnHourChanged?.Invoke();
            }
            timer = minuteToRealTime;
        }
    }
    public void LoadData(GameData data){
        TimeMan.Minute = data.Minute;
        TimeMan.Hour = data.Hour;
    }
    public void SaveData(ref GameData data){
        data.Minute = TimeMan.Minute;
        data.Hour = TimeMan.Hour;
    }
}
