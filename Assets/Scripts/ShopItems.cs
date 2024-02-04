using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopItems : MonoBehaviour
{

    public Item item;
    //public SpriteRenderer image;
    public Image image;
    public Text DescTxt, AtkTxt, DefTxt, GoldTxt;
    public void SetItem(Item _item)
    {
        item.Name = _item.Name;
        item.itemImage = _item.itemImage;
        item.itemType = _item.itemType;

        //image.sprite = item.itemImage;
        image.sprite = item.itemImage;
        //todo : �����鿡 text �ְ� Ȯ��
    }

    public void SetItemDesc(Item _item)
    {
        item.Desc = _item.Desc;
        DescTxt.text = item.Desc;
    }
    public void ItemTypeMatch(Item _item)
    {
        if (_item.Atk > 0)
        {
            SetItemAtk(_item);
        }
        else
            SetItemDef(_item);
    }
    public void SetItemAtk(Item _item)
    {
        item.Atk = _item.Atk;
        AtkTxt.text = (item.Atk).ToString();
    }
    public void SetItemDef(Item _item)
    {
        item.Def = _item.Def;
        DefTxt.text = (item.Def).ToString();
    }
    public void SetItemGold(Item _item)
    {
        item.Gold = _item.Gold;
        GoldTxt.text = (item.Gold).ToString();
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
