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
            //인벤토리 패널을 끄고 킨다.
            //과제에서는 우선 InventoryUI를 이용(클릭 등)
        }
    }

    void ItemEquied()
    {

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
            return;
        }
        else if (Inventory.instance.inventory[i].isEquied == false)
        {
            Debug.Log(Inventory.instance.inventory[i].Name + "을 장착했습니다.");
            Inventory.instance.inventory[i].isEquied = true;
        }
        else if (Inventory.instance.inventory[i].isEquied == true)
        {
            Debug.Log(Inventory.instance.inventory[i].Name + "을 장착해제했습니다.");
            Inventory.instance.inventory[i].isEquied = false;
        }
        PlayerManager.instance.StatUpdate();
    }
}
