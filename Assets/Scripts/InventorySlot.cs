using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlot : MonoBehaviour
{
    ShopItems shopItems;

    public void OnClickEquied()
    {
        shopItems = GetComponent<ShopItems>();


        Debug.Log(shopItems.item.Name + "을 장착했습니다.");
    }

}
