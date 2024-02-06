using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    Inventory inventory;

    public GameObject inventoryPanel;
    bool isActiveInventory = false;
    // Start is called before the first frame update
    void Start()
    {
        inventory = Inventory.instance;

        inventoryPanel.SetActive(isActiveInventory);
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
        if (Inventory.instance.inventory[i].isEquied == false)
        {
            Debug.Log(Inventory.instance.inventory[i].Name + "�� �����߽��ϴ�.");
            Inventory.instance.inventory[i].isEquied = true;
        }
        PlayerManager.instance.StatUpdate();
    }
}
