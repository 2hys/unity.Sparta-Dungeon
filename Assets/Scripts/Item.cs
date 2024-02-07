using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public enum ItemType
    {
        Weapon,
        Hat,
        Armor,
        Ring,
        Etc//potion?
    }
    public ItemType itemType;
    public string Type, Name, Desc;
    public int Gold, Atk, Def, Number;
    public Sprite itemImage;
    public bool isEquied;

    public bool weaponIsEquied = false;
    public bool hatIsEquied = false;
    public bool armorIsEquied = false;
    public bool ringIsEquied = false;


    public bool Equiped()
    {
        return false;
    }
}
