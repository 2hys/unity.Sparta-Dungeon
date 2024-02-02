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

    //SetItem���� ���� ���ŵ� ������ �������� �ѱ�.
    public Item BuyItem()
    {
        return item;
    }


    //public void DestryItem()
    //Destory��������.
    //�̹� �����߾ �߰� ���� ����.
}
