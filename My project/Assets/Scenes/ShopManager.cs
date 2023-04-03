using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ShopManager : MonoBehaviour
{
 
    public int coins;
    public GameObject image1;
    public GameObject image2;
    public GameObject image3;
    public GameObject image4;

    public TextMeshProUGUI price1;
    public TextMeshProUGUI price2;
    public TextMeshProUGUI price3;
    public TextMeshProUGUI price4;

    public TextMeshProUGUI coinTXT;

    public Shop image;
    private LootShop item1;
    private LootShop item2;
    private LootShop item3;
    private LootShop item4;
    // Start is called before the first frame update
    public GameObject PanelNoMoney;
    public MainManager managaMain;
    // Update is called once per frame
    void Start()
    {
        coins = managaMain.getCoins();
        item1 = image.InstantiateLoot();
        item2 = image.InstantiateLoot();
        item3 = image.InstantiateLoot();
        item4 = image.InstantiateLoot();

        Sprite imagee1 = item1.lootSprite;
        Sprite imagee2 = item2.lootSprite;
        Sprite imagee3 = item3.lootSprite;
        Sprite imagee4 = item4.lootSprite;

        image1.GetComponent<Image>().sprite = imagee1;
        image2.GetComponent<Image>().sprite = imagee2;
        image3.GetComponent<Image>().sprite = imagee3;
        image4.GetComponent<Image>().sprite = imagee4;

        int priceItem1 = item1.value;
        int priceItem2 = item2.value;
        int priceItem3 = item3.value;
        int priceItem4 = item4.value;

        price1.text = "Price: " + priceItem1.ToString();
        price2.text = "Price: " + priceItem2.ToString();
        price3.text = "Price: " + priceItem3.ToString();
        price4.text = "Price: " + priceItem4.ToString();

        coinTXT.text = "Coins: " + coins.ToString();

    }

    public void returnLevel()
    {
        SceneManager.LoadScene(1);
        //return load system!!
    }

    public void buyItem1()
    {
        if(coins>= item1.value)
        {
            coins = coins - item1.value;
            coinTXT.text = "Coins: " + coins.ToString();
        }
        else
        {
            PanelNoMoney.SetActive(true);
        }
    }

    public void buyItem2()
    {
        if(coins >= item2.value)
        {
            coins = coins - item2.value;
            coinTXT.text = "Coins: " + coins.ToString();
        }
        else
        {
            PanelNoMoney.SetActive(true);
        }
    }

    public void buyItem3()
    {
        if(coins >= item3.value)
        {
            coins = coins - item3.value;
            coinTXT.text = "Coins: " + coins.ToString();
        }
        else
        {
            PanelNoMoney.SetActive(true);
        }
    }

    public void buyItem4()
    {
        if(coins >= item4.value)
        {
            coins = coins - item4.value;
            coinTXT.text = "Coins: " + coins.ToString();
        }
        else
        {
            PanelNoMoney.SetActive(true);
        }
    }

    public void returnToShoo()
    {
        PanelNoMoney.SetActive(false);
    }
}
