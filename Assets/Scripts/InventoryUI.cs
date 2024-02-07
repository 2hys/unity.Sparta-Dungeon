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
            //�κ��丮 �г��� ���� Ų��.
            //���������� �켱 InventoryUI�� �̿�(Ŭ�� ��)
        }
    }

    void ItemTypeMatch(Item item)
    {
        //1. itemtype �Ǻ�.
        //2. ���� Ÿ���� �̹� �������϶��� ������������.(return ;)
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
            Debug.Log("�κ��丮�� ������ϴ�.");
            return;
        }
        
        if (Inventory.instance.inventory[i].itemType == Item.ItemType.Weapon)
        {
            if (PlayerManager.instance.weaponIsEquied == false)
            {
                Debug.Log(Inventory.instance.inventory[i].Name + "�� �����߽��ϴ�.");
                PlayerManager.instance.weaponIsEquied = true;
                EuqiedImage.SetActive(true);
            }
            else
            {
                Debug.Log(Inventory.instance.inventory[i].Name + "�� ���������߽��ϴ�.");
                PlayerManager.instance.weaponIsEquied = false;
                EuqiedImage.SetActive(false);
            }
        }

        if (Inventory.instance.inventory[i].itemType == Item.ItemType.Hat)
        {
            if (PlayerManager.instance.hatIsEquied == false)
            {
                Debug.Log(Inventory.instance.inventory[i].Name + "�� �����߽��ϴ�.");
                PlayerManager.instance.hatIsEquied = true;
                EuqiedImage.SetActive(true);
            }
            else
            {
                Debug.Log(Inventory.instance.inventory[i].Name + "�� ���������߽��ϴ�.");
                PlayerManager.instance.hatIsEquied = false;
                EuqiedImage.SetActive(false);
            }
        }

        if (Inventory.instance.inventory[i].itemType == Item.ItemType.Armor)
        {
            if (PlayerManager.instance.armorIsEquied == false)
            {
                Debug.Log(Inventory.instance.inventory[i].Name + "�� �����߽��ϴ�.");
                PlayerManager.instance.armorIsEquied = true;
                EuqiedImage.SetActive(true);
            }
            else
            {
                Debug.Log(Inventory.instance.inventory[i].Name + "�� ���������߽��ϴ�.");
                PlayerManager.instance.armorIsEquied = false;
                EuqiedImage.SetActive(false);
            }
        }

        if (Inventory.instance.inventory[i].itemType == Item.ItemType.Ring)
        {
            if (PlayerManager.instance.ringIsEquied == false)
            {
                Debug.Log(Inventory.instance.inventory[i].Name + "�� �����߽��ϴ�.");
                PlayerManager.instance.ringIsEquied = true;
                EuqiedImage.SetActive(true);
            }
            else
            {
                Debug.Log(Inventory.instance.inventory[i].Name + "�� ���������߽��ϴ�.");
                PlayerManager.instance.ringIsEquied = false;
                EuqiedImage.SetActive(false);
            }
        }
        //ETC ������(�Һ� ��) �߰���
        /*
        if (Inventory.instance.inventory[i].itemType == Item.ItemType.Etc)
        {
            if (PlayerManager.instance.weaponIsEquied == false)
            {
                Debug.Log(Inventory.instance.inventory[i].Name + "�� �����߽��ϴ�.");
                PlayerManager.instance.weaponIsEquied = true;
                EuqiedImage.SetActive(true);
            }
            else
            {
                Debug.Log(Inventory.instance.inventory[i].Name + "�� ���������߽��ϴ�.");
                PlayerManager.instance.weaponIsEquied = false;
                EuqiedImage.SetActive(false);
            }
        }
        */
        PlayerManager.instance.StatUpdate();
    }
}
