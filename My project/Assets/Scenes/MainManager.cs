using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    //set inventory
    public static MainManager playerStats;
    public TextMeshProUGUI prestigeTXT;
    public TextMeshProUGUI coinsTXT;

    public int prestige;
    public int coins;

    public int getCoins()
    {
        return coins;
    }
}

