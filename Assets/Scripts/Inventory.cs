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
    //������ �������� ���� List
    List<Item> inventory = new List<Item>();

    public List<Item> itemDB = new List<Item>();

    public GameObject inventoryItemPrefeb;
    public GameObject content;

    void Start()
    {
        
    }

    //ShopItems shopItems = new ShopItems();//todo : ?


    //PlayerManager player = new PlayerManager();

    /*
    public bool AddItem(Item _item)
    {
        Debug.Log("��ư����");
        Debug.Log(_item.Gold);
        Debug.Log(PlayerManager.gold);

        if (_item.Gold <= PlayerManager.gold)
        {
            inventory.Add(_item);
            PlayerManager.gold -= _item.Gold;
            Debug.Log("������ ���� �Ϸ�");
            return true;
        }
        return false;
    }
    */
    /*
    ShopItems shopItems = new ShopItems();
    public bool AddItem(Item _item)
    {
        inventory.Add(_item);
        Debug.Log(inventory.Count);
        return true;
    }

    public void ShopBuy()
    {
        if (AddItem(shopItems.BuyItem()))
        {
            Debug.Log("������ ���ſ� �����߽��ϴ�.");
        }
        else
            Debug.Log("��尡 �����մϴ�.");
    }
    */
}
