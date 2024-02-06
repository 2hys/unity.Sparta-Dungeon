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
            //인벤토리 패널을 끄고 킨다.
            //과제에서는 우선 InventoryUI를 이용(클릭 등)
        }
    }

    void ItemEquied()
    {

    }
    public void OnClickEquied(int i)
    {
        if (Inventory.instance.inventory[i].isEquied == false)
        {
            Debug.Log(Inventory.instance.inventory[i].Name + "을 장착했습니다.");
            Inventory.instance.inventory[i].isEquied = true;
        }
        PlayerManager.instance.StatUpdate();
    }
}
