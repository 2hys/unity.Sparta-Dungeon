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

    //������ �������� ���� List
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
                Debug.Log("������ ���� �Ϸ�");
            }
            else
                Debug.Log("�� ������");
        }
        else
            Debug.Log("�� �̻� �������� ������ �� �����ϴ�(�κ��丮 ���� ����)");
        Debug.Log("�κ��丮ī��Ʈ : " + inventory.Count);
    }
    /*
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
