using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class ShopItems : MonoBehaviour
{

    public Item item;
    //public SpriteRenderer image;
    public Image image;
    public Text DescTxt, AtkTxt, DefTxt, GoldTxt;
    public Button btn;

    //ItemDatabase itemDatabase;

    public int itemnumber;
    private void Awake()
    {
        //itemDatabase = GetComponent<ItemDatabase>();
    }

    public void SetItem(Item _item)
    {
        item.Name = _item.Name;
        item.itemImage = _item.itemImage;
        item.itemType = _item.itemType;
        item.Gold = _item.Gold;
        image.sprite = item.itemImage;
    }

    public void SetBuyItem(Item _item)
    {
        item.Gold = _item.Gold;
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
    //SetItem에서 넣은 구매될 아이템 정보들을 넘김.
    public int SetItemBuyBtn(Item _item)
    {
        return itemnumber = _item.Number;
    }
    public Item BuyItem()
    {
        return item;
    }
    public void Is()
    {
        Debug.Log("Check");
    }

    public void OnClick()
    {
        Debug.Log("Click");
        Inventory.instance.AddItem(ItemDatabase.instance.itemDB[0]);
    }


    //public void DestryItem()
    //Destory하지않음.
    //이미 구매했어도 추가 구매 가능.
}
