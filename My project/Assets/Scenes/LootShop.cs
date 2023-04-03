using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class LootShop:ScriptableObject
{
    public Sprite lootSprite;
    public string lootName;
    public int dropChance;

        public LootShop(string lootName, int dropChance)
    {
        this.lootName = lootName;
        this.dropChance = dropChance;
    }
}
