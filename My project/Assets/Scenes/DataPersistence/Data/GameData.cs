using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class GameData
{
    //public int coinCount;
    public float totalTime;
    public float currentTime;
    public Vector3 PlayerPosition;
    public GameData()
    {
       // this.coinCount = 0;
        this.totalTime = 0;
        this.currentTime = 0;
        PlayerPosition = new Vector3(0f,-2f,0f);
    }

}
