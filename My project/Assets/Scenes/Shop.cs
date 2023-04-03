using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Shop : MonoBehaviour
{
    public List<LootShop> lootlist = new List<LootShop>();

    // Start is called before the first frame update
    
    LootShop PickItem()
    {
        int randomNumber = Random.Range(1, 101);
        List<LootShop> possibleItems = new List<LootShop>();
        foreach (LootShop item in lootlist)
        {
            if(randomNumber <= item.dropChance)
            {
                possibleItems.Add(item);
               
            }
        }

        if(possibleItems.Count>0)
        {
            LootShop item = possibleItems[Random.Range(0, possibleItems.Count)];
            print(item.lootName);
            return item;
        }
        return null;
    }
}
