using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu]
public class LootShop:ScriptableObject
{
    [field: SerializeField]
    public bool IsStackable { get; set; }

    public int ID => GetInstanceID();

    [field: SerializeField]
    public int MaxStackSize { get; set; } = 1;

    [field: SerializeField]
    public string lootName { get; set; }

    [field: SerializeField]
    [field: TextArea]
    public string description { get; set; }

    [field: SerializeField]
    public Sprite lootSprite { get; set; }

    [field: SerializeField]
    public int dropChance { get; set; }

    [field: SerializeField]
    public int value { get; set; }

    [field: SerializeField]
    public int pres { get; set; }

    // public Sprite lootSprite;
    //public string lootName;
    //public int dropChance;
    //public int value;
    //public int pres;
   // public string description;

        public LootShop(string lootName, int dropChance, int value,
            int pres, string descrpition)
    {
        this.lootName = lootName;
        this.dropChance = dropChance;
        this.value = value;
        this.pres = pres;
        this.description = description;

    }
}
