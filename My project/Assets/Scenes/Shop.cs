using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Shop : MonoBehaviour
{
    public List<LootShop> lootlist = new List<LootShop>();
    public GameObject ImagePref;
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
            LootShop itemPick = possibleItems[Random.Range(0, possibleItems.Count)];
            print(itemPick.lootName);
            return itemPick;
        }

        if (possibleItems.Count == 0)
        {
           
            return lootlist[1];
        }

        Debug.Log("does not create");
        return null;
    }

    //Vector3 spawnPosition
    public LootShop InstantiateLoot()
    {
        LootShop getItem = PickItem();
        
        //GameObject lootGameObject = Instantiate(ImagePref, spawnPosition, Quaternion.identity);
       // lootGameObject.GetComponent<SpriteRenderer>().sprite = getItem.lootSprite;
        //Sprite newImage = getItem.lootSprite;
        return getItem;
    }

  
}
