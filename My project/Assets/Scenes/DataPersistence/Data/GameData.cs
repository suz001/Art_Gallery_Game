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
    public int coins;
    public int prestige;
    public InventoryList inventoryData{ get; set; }



    public GameData()
    {
       // this.coinCount = 0;
        this.Minute =0;
        this.Hour = 6;
        PlayerPosition = new Vector3(0f,-2f,0f);
        this.coins = 5000;
        this.prestige = 10;
        
      
        
        //check1.SetActive(false);
        
        
    }

}

