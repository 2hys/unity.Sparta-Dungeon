using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    #region Singleton
    public static PlayerManager instance;
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
    }
    #endregion
    [SerializeField]
    public static float atk = 35;
    public static float def = 40;
    public static float hp = 100;
    public static float cri = 25;
    public static string playerName = "Chad";
    public static string playerDesc = "ÇÇ°ïÇÑ »óÅÂÀÔ´Ï´Ù.";

    public static float WeaponAtk, WeaponDef, HatAtk, HatDef, ArmorAtk, ArmorDef, RingAtk, RingDef = 0;
    //
    [SerializeField] public static int gold = 1500;
    public static int playerLevel = 1;
    public static float exp;

    public bool weaponIsEquied = false;
    public bool hatIsEquied = false;
    public bool armorIsEquied = false;
    public bool ringIsEquied = false;

    public void StatUpdate()
    {
        for(int i = 0; i < Inventory.instance.inventory.Count; i++)
        {
            Debug.Log(Inventory.instance.inventory[i].Name + "ÀÇ ÀåÂøÀ» È®ÀÎÁß");
            Debug.Log(Inventory.instance.inventory[i].Desc + " : ¼³¸í");

            if (Inventory.instance.inventory[i].weaponIsEquied == false && Inventory.instance.inventory[i].itemType == Item.ItemType.Weapon)
            {
                Debug.Log(Inventory.instance.inventory[i].Name + "ÀÇ ÀåÂøÀ» È®ÀÎÇÔ. ½ºÅÝ Àû¿ë");
                WeaponAtk += Inventory.instance.inventory[i].Atk;
                WeaponDef += Inventory.instance.inventory[i].Def;
            }
            else//ÀåÂøÇØÁ¦
            {
                WeaponAtk = 0;
                WeaponDef = 0;
                Debug.Log(Inventory.instance.inventory[i].Name + "Àº ÀåÂøÁßÀÌÁö ¾ÊÀ½.");
            }

            if (Inventory.instance.inventory[i].hatIsEquied == false && Inventory.instance.inventory[i].itemType == Item.ItemType.Hat)
            {
                Debug.Log(Inventory.instance.inventory[i].Name + "ÀÇ ÀåÂøÀ» È®ÀÎÇÔ. ½ºÅÝ Àû¿ë");
                HatAtk += Inventory.instance.inventory[i].Atk;
                HatDef += Inventory.instance.inventory[i].Def;
            }

            else//ÀåÂøÇØÁ¦
            {
                HatAtk = 0;
                HatDef = 0;
                Debug.Log(Inventory.instance.inventory[i].Name + "Àº ÀåÂøÁßÀÌÁö ¾ÊÀ½.");
            }

            if (Inventory.instance.inventory[i].armorIsEquied == false && Inventory.instance.inventory[i].itemType == Item.ItemType.Armor)
            {
                Debug.Log(Inventory.instance.inventory[i].Name + "ÀÇ ÀåÂøÀ» È®ÀÎÇÔ. ½ºÅÝ Àû¿ë");
                ArmorAtk += Inventory.instance.inventory[i].Atk;
                ArmorDef += Inventory.instance.inventory[i].Def;
            }
            else//ÀåÂøÇØÁ¦
            {
                ArmorAtk = 0;
                ArmorDef = 0;
                Debug.Log(Inventory.instance.inventory[i].Name + "Àº ÀåÂøÁßÀÌÁö ¾ÊÀ½.");
            }

            if (Inventory.instance.inventory[i].ringIsEquied == false && Inventory.instance.inventory[i].itemType == Item.ItemType.Ring)
            {
                Debug.Log(Inventory.instance.inventory[i].Name + "ÀÇ ÀåÂøÀ» È®ÀÎÇÔ. ½ºÅÝ Àû¿ë");
                RingAtk += Inventory.instance.inventory[i].Atk;
                RingDef += Inventory.instance.inventory[i].Def;
            }
            else//ÀåÂøÇØÁ¦
            {
                RingAtk = 0;
                RingDef = 0;
                Debug.Log(Inventory.instance.inventory[i].Name + "Àº ÀåÂøÁßÀÌÁö ¾ÊÀ½.");
            }
        }
        UIManager.instance.UIUpdate();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
