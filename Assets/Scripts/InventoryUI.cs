using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    Inventory inventory;

    bool isActiveInventory = false;
    // Start is called before the first frame update
    void Start()
    {
        inventory = Inventory.instance;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            //�κ��丮 �г��� ���� Ų��.
            //���������� �켱 InventoryUI�� �̿�(Ŭ�� ��)
        }
    }

    void ItemEquied()
    {

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
            return;
        }
        else if (Inventory.instance.inventory[i].isEquied == false)
        {
            Debug.Log(Inventory.instance.inventory[i].Name + "�� �����߽��ϴ�.");
            Inventory.instance.inventory[i].isEquied = true;
        }
        else if (Inventory.instance.inventory[i].isEquied == true)
        {
            Debug.Log(Inventory.instance.inventory[i].Name + "�� ���������߽��ϴ�.");
            Inventory.instance.inventory[i].isEquied = false;
        }
        PlayerManager.instance.StatUpdate();
    }
}
