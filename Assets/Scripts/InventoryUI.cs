using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class InventoryUI : MonoBehaviour
{
    Inventory inventory;

    bool isActiveInventory = false;
    // Start is called before the first frame update
    void Start()
    {
        inventory = Inventory.instance;

    }

    public GameObject EuqiedImage;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            //인벤토리 패널을 끄고 킨다.
            //과제에서는 우선 InventoryUI를 이용(클릭 등)
        }
    }

    void ItemTypeMatch(Item item)
    {
        //1. itemtype 판별.
        //2. 같은 타입이 이미 착용중일때는 착용하지않음.(return ;)
        if (item.itemType == Item.ItemType.Weapon)
        {
            if (PlayerManager.instance.weaponIsEquied == false)
            {
                PlayerManager.instance.weaponIsEquied = true;
                EuqiedImage.SetActive(true);
            }
            else
                PlayerManager.instance.weaponIsEquied = false;
        }
    }
    public void OnClickEquied(int i)
    {
        if (Inventory.instance.inventory.Count <= i)
        {
            Debug.Log("인벤토리가 비었습니다.");
            return;
        }
        
        if (Inventory.instance.inventory[i].itemType == Item.ItemType.Weapon)
        {
            if (PlayerManager.instance.weaponIsEquied == false)
            {
                Debug.Log(Inventory.instance.inventory[i].Name + "을 장착했습니다.");
                PlayerManager.instance.weaponIsEquied = true;
                EuqiedImage.SetActive(true);
            }
            else
            {
                Debug.Log(Inventory.instance.inventory[i].Name + "을 장착해제했습니다.");
                PlayerManager.instance.weaponIsEquied = false;
                EuqiedImage.SetActive(false);
            }
        }

        if (Inventory.instance.inventory[i].itemType == Item.ItemType.Hat)
        {
            if (PlayerManager.instance.hatIsEquied == false)
            {
                Debug.Log(Inventory.instance.inventory[i].Name + "을 장착했습니다.");
                PlayerManager.instance.hatIsEquied = true;
                EuqiedImage.SetActive(true);
            }
            else
            {
                Debug.Log(Inventory.instance.inventory[i].Name + "을 장착해제했습니다.");
                PlayerManager.instance.hatIsEquied = false;
                EuqiedImage.SetActive(false);
            }
        }

        if (Inventory.instance.inventory[i].itemType == Item.ItemType.Armor)
        {
            if (PlayerManager.instance.armorIsEquied == false)
            {
                Debug.Log(Inventory.instance.inventory[i].Name + "을 장착했습니다.");
                PlayerManager.instance.armorIsEquied = true;
                EuqiedImage.SetActive(true);
            }
            else
            {
                Debug.Log(Inventory.instance.inventory[i].Name + "을 장착해제했습니다.");
                PlayerManager.instance.armorIsEquied = false;
                EuqiedImage.SetActive(false);
            }
        }

        if (Inventory.instance.inventory[i].itemType == Item.ItemType.Ring)
        {
            if (PlayerManager.instance.ringIsEquied == false)
            {
                Debug.Log(Inventory.instance.inventory[i].Name + "을 장착했습니다.");
                PlayerManager.instance.ringIsEquied = true;
                EuqiedImage.SetActive(true);
            }
            else
            {
                Debug.Log(Inventory.instance.inventory[i].Name + "을 장착해제했습니다.");
                PlayerManager.instance.ringIsEquied = false;
                EuqiedImage.SetActive(false);
            }
        }
        //ETC 아이템(소비 등) 추가시
        /*
        if (Inventory.instance.inventory[i].itemType == Item.ItemType.Etc)
        {
            if (PlayerManager.instance.weaponIsEquied == false)
            {
                Debug.Log(Inventory.instance.inventory[i].Name + "을 장착했습니다.");
                PlayerManager.instance.weaponIsEquied = true;
                EuqiedImage.SetActive(true);
            }
            else
            {
                Debug.Log(Inventory.instance.inventory[i].Name + "을 장착해제했습니다.");
                PlayerManager.instance.weaponIsEquied = false;
                EuqiedImage.SetActive(false);
            }
        }
        */
        PlayerManager.instance.StatUpdate();
    }
}
