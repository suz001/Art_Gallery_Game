using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    [field: SerializeField]
    public LootShop InventoryItem { get; private set; }

    [field: SerializeField]
    public int Quantity { get; set; } = 1;

   

}
