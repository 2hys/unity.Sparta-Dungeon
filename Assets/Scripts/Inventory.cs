using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Inventory : MonoBehaviour
{
    #region Singleton
    public static Inventory instance;
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
 

    //public List<Item> itemDB = new List<Item>();

    //소유한 아이템을 담을 List
    public List<Item> inventory = new List<Item>();
    public GameObject inventoryItemPrefeb;
    public GameObject content;


    public bool hatIsEquied = false;
    public bool armorIsEquied = false;
    public bool weaponIsEquied = false;
    public bool ringIsEquied = false;



    void Start()
    {
        for (int i = 0; i < inventory.Count; i++)
        {
            GameObject inventoryitem = Instantiate(inventoryItemPrefeb);
            inventoryitem.transform.parent = content.transform;
            inventoryitem.GetComponentInChildren<ShopItems>().SetItem(inventory[i]);
        }
    }


    private void Update()
    {
        //Debug.Log(inventory.Count);
    }

    //ShopItems shopItems = new ShopItems();
    public void AddItem(Item _item)
    {
        if (inventory.Count < 9)
        {
            if (_item.Gold <= PlayerManager.gold)
            {
                inventory.Add(_item);
                GameObject inventoryitem = Instantiate(inventoryItemPrefeb);
                inventoryitem.transform.parent = content.transform;
                inventoryitem.GetComponentInChildren<ShopItems>().SetItem(_item);
                PlayerManager.gold -= _item.Gold;
                Debug.Log("아이템 구매 완료");
            }
            else
                Debug.Log("돈 부족함");
        }
        else
            Debug.Log("더 이상 아이템을 구매할 수 없습니다(인벤토리 슬롯 부족)");
        Debug.Log("인벤토리카운트 : " + inventory.Count);
    }
    /*
    public void ShopBuy()
    {
        if (AddItem(shopItems.BuyItem()))
        {
            Debug.Log("아이템 구매에 성공했습니다.");
        }
        else
            Debug.Log("골드가 부족합니다.");
    }
    */
}
