using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class LootShop:ScriptableObject
{
    public Sprite lootSprite;
    public string lootName;
    public int dropChance;
    public int value;

        public LootShop(string lootName, int dropChance, int value)
    {
        this.lootName = lootName;
        this.dropChance = dropChance;
        this.value = value;
    }
}
