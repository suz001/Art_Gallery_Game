using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetTimeManager : MonoBehaviour, IdDataPersistence
{
    public const int hoursInDay = 24, minutesInHour = 60;

    public float dayDuration = 30f;

    private float totalTime = 0;
    private float currentTime = 0;


    // Update is called once per frame
    void Update()
    {
        
        totalTime += Time.deltaTime;
        currentTime = totalTime % dayDuration;
        
    }

    public float GetHour()
    {
        Debug.Log(totalTime);
        return currentTime * hoursInDay / dayDuration;
        
    }

    public float GetMinutes()
    {
        return (currentTime * hoursInDay * minutesInHour / dayDuration) % minutesInHour;
    }

    public string Clock24Hour()
    {
        //00:00
        return Mathf.FloorToInt(GetHour()).ToString("00") + ":" + Mathf.FloorToInt(GetMinutes()).ToString("00");
    }

    public string Clock12Hour()
    {
        int hour = Mathf.FloorToInt(GetHour());
        string abbreviation = "AM";

        if (hour >= 12)
        {
            abbreviation = "PM";
            hour -= 12;
        }

        if (hour == 0) hour = 12;

        return hour.ToString("00") + ":" + Mathf.FloorToInt(GetMinutes()).ToString("00") + " " + abbreviation;
    }
    public void LoadData(GameData data){
        this.totalTime = data.totalTime;
        //this.currentTime = data.currentTime;
        Debug.Log("Data saved");

    }
    public void SaveData(ref GameData data){
        //data.totalTime = this.totalTime;
        //data.currentTime = this.currentTime;
        Debug.Log("Data saved");

    }
}