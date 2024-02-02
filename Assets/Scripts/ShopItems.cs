using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopItems : MonoBehaviour
{

    public Item item;
    public SpriteRenderer image;

    public void SetItem(Item _item)
    {
        item.Name = _item.Name;
        item.itemImage = _item.itemImage;
        item.itemType = _item.itemType;

        image.sprite = item.itemImage;
    }

    //SetItem에서 넣은 구매될 아이템 정보들을 넘김.
    public Item BuyItem()
    {
        return item;
    }


    //public void DestryItem()
    //Destory하지않음.
    //이미 구매했어도 추가 구매 가능.
}
