using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    //������ �������� ���� List�� ����
    List<Item> inventory = new List<Item>();

    ShopItems shopItems = new ShopItems();//todo : ?

    public bool AddItem(Item _item)
    {
        if (_item.Gold <= DataManager.Player.gold)
        {
            inventory.Add(_item);
            DataManager.Player.gold -= _item.Gold;
            return true;
        }
        return false;
    }

    public void ShopBuy()
    {
        if (AddItem(shopItems.BuyItem()))
        {
            Debug.Log("������ ���ſ� �����߽��ϴ�.");
        }
        Debug.Log("��尡 �����մϴ�.");
    }
}
