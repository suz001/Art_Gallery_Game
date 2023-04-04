using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decorate : MonoBehaviour
{
    public List<InventoryItem> initialItems = new List<InventoryItem>();
    [SerializeField]
    private InventoryList inventoryData;
    public void Update()
    {
       
        foreach (var item in initialItems)
        {
            
            if (item.item.lootName=="item1")
            {
                print("1");
            }
            if (item.item.lootName == "item2")
            {
                print("2");
            }
            if (item.item.lootName == "item3")
            {
                print("3");
            }
            if (item.item.lootName == "item4")
            {
                print("4");
            }
            if (item.item.lootName == "item5")
            {
                print("5");
            }
            if (item.item.lootName == "item6")
            {
                print("6");
            }
            if (item.item.lootName == "item7")
            {
                print("7");
            }
            if (item.item.lootName == "item8")
            {
                print("8");
            }
            if (item.item.lootName == "item9")
            {
                print("9");
            }
            if (item.item.lootName == "item10")
            {
                print("10");
            }
        }
    }
}
