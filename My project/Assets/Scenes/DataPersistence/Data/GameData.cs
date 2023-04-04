using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class GameData
{
    //public int coinCount;
    public int Minute;
    public int Hour;
    public Vector3 PlayerPosition;
    public GameData()
    {
       // this.coinCount = 0;
        this.Minute =0;
        this.Hour = 6;
        PlayerPosition = new Vector3(0f,-2f,0f);
    }

}

