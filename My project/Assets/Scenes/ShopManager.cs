using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System;

public class ShopManager : MonoBehaviour
{

    [SerializeField]
    private InventoryList inventoryData;

    public MainManager stats;
    private int coins;
    private int pres;
    public GameObject image1;
    public GameObject image2;
    public GameObject image3;
    public GameObject image4;

    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;

    public GameObject check1;
    public GameObject check2;
    public GameObject check3;
    public GameObject check4;
    public GameObject check5;
    public GameObject check6;
    public GameObject check7;
    public GameObject check8;
    public GameObject check9;
    public GameObject check10;


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
    public GameObject shopPanel;
    //public List<InventoryItem> initialItems = new List<InventoryItem>();
    // Update is called once per frame

    void Start()
    {
        //coins = managaMain.getCoins();
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

        coins = stats.getCoins();
        pres = stats.getPres();
        coinTXT.text = "Coins: " + coins.ToString();

    }

    public void returnLevel()
    {
        shopPanel.SetActive(false);
    }

    public void buyItem1()
    {
        if(coins>= item1.value)
        {
            coins = coins - item1.value;
            coinTXT.text = "Coins: " + coins.ToString();
            inventoryData.AddItem(item1, 1);
            pres = pres + item1.pres;

            stats.setCoins(coins);
            stats.setPres(pres);

            if(item1.lootName=="item1")
            {
                check10.SetActive(true);
            }
            if (item1.lootName == "item2")
            {
                check9.SetActive(true);
            }
            if (item1.lootName == "item3")
            {
                check8.SetActive(true);
            }
            if (item1.lootName == "item4")
            {
                check7.SetActive(true);
            }
            if (item1.lootName == "item5")
            {
                check6.SetActive(true);
            }
            if (item1.lootName == "item6")
            {
                check5.SetActive(true);
            }
            if (item1.lootName == "item7")
            {
                check4.SetActive(true);
            }
            if (item1.lootName == "item8")
            {
                check3.SetActive(true);
            }
            if (item1.lootName == "item9")
            {
                check2.SetActive(true);
            }
            if (item1.lootName == "item10")
            {
                check1.SetActive(true);
            }
            

            button1.SetActive(false);
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
            inventoryData.AddItem(item2,1);
            pres = pres + item2.pres;

            stats.setCoins(coins);
            stats.setPres(pres);

            if (item2.lootName == "item1")
            {
                check10.SetActive(true);
            }
            if (item2.lootName == "item2")
            {
                check9.SetActive(true);
            }
            if (item2.lootName == "item3")
            {
                check8.SetActive(true);
            }
            if (item2.lootName == "item4")
            {
                check7.SetActive(true);
            }
            if (item2.lootName == "item5")
            {
                check6.SetActive(true);
            }
            if (item2.lootName == "item6")
            {
                check5.SetActive(true);
            }
            if (item2.lootName == "item7")
            {
                check4.SetActive(true);
            }
            if (item2.lootName == "item8")
            {
                check3.SetActive(true);
            }
            if (item2.lootName == "item9")
            {
                check2.SetActive(true);
            }
            if (item2.lootName == "item10")
            {
                check1.SetActive(true);
            }


            button2.SetActive(false);
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
            inventoryData.AddItem(item3, 1);
            pres = pres + item3.pres;

            stats.setCoins(coins);
            stats.setPres(pres);

            if (item3.lootName == "item1")
            {
                check10.SetActive(true);
            }
            if (item3.lootName == "item2")
            {
                check9.SetActive(true);
            }
            if (item3.lootName == "item3")
            {
                check8.SetActive(true);
            }
            if (item3.lootName == "item4")
            {
                check7.SetActive(true);
            }
            if (item3.lootName == "item5")
            {
                check6.SetActive(true);
            }
            if (item3.lootName == "item6")
            {
                check5.SetActive(true);
            }
            if (item3.lootName == "item7")
            {
                check4.SetActive(true);
            }
            if (item3.lootName == "item8")
            {
                check3.SetActive(true);
            }
            if (item3.lootName == "item9")
            {
                check2.SetActive(true);
            }
            if (item3.lootName == "item10")
            {
                check1.SetActive(true);
            }


            button3.SetActive(false);
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
        inventoryData.AddItem(item4, 1);
            pres = pres + item4.pres;

            stats.setCoins(coins);
            stats.setPres(pres);

            if (item4.lootName == "item1")
            {
                check10.SetActive(true);
            }
            if (item4.lootName == "item2")
            {
                check9.SetActive(true);
            }
            if (item4.lootName == "item3")
            {
                check8.SetActive(true);
            }
            if (item4.lootName == "item4")
            {
                check7.SetActive(true);
            }
            if (item4.lootName == "item5")
            {
                check6.SetActive(true);
            }
            if (item4.lootName == "item6")
            {
                check5.SetActive(true);
            }
            if (item4.lootName == "item7")
            {
                check4.SetActive(true);
            }
            if (item4.lootName == "item8")
            {
                check3.SetActive(true);
            }
            if (item4.lootName == "item9")
            {
                check2.SetActive(true);
            }
            if (item4.lootName == "item10")
            {
                check1.SetActive(true);
            }

            button4.SetActive(false);
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

    public LootShop BuyItem1()
    {
        return item1;
    }
    public LootShop BuyItem2()
    {
        return item2;
    }
    public LootShop BuyItem3()
    {
        return item3;
    }
    public LootShop BuyItem4()
    {
        return item4;
    }

    
}
