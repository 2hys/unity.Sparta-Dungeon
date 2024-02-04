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

    //소유한 아이템을 담을 List를 생성
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
            Debug.Log("아이템 구매에 성공했습니다.");
        }
        Debug.Log("골드가 부족합니다.");
    }
}
