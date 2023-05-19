using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinUpdate : MonoBehaviour
{
    public MainManager stats;
    private int coins;
 
    private void OnEnable()
    {

        TimeManag.OnMinuteChanged += UpdateTime;
        TimeManag.OnHourChanged += UpdateTime;

    }
    private void OnDisable()
    {
        TimeManag.OnMinuteChanged -= UpdateTime;
        TimeManag.OnHourChanged -= UpdateTime;
    }
    private void UpdateTime()
    {

        if(TimeManag.Hour==13)
        {
            coins = stats.getCoins();
            stats.setCoins(coins + 1);
        }
        else if(TimeManag.Hour==15)
        {
            coins = stats.getCoins();
            stats.setCoins(coins + 1);
        }
        else if(TimeManag.Hour==17)
        {
            coins = stats.getCoins();
            stats.setCoins(coins + 1);
        }
    }

}
