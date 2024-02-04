using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemDatabase : MonoBehaviour
{
    public static ItemDatabase instance;
    private void Awake()
    {
        instance = this;
    }

    public List<Item> itemDB = new List<Item>();
    public List<Item> inventory = new List<Item>();

    public GameObject shopItemPrefeb;
    public GameObject content;

    public GameObject inventoryItemPrefeb;
    public GameObject inventoryContent;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            GameObject shopitem = Instantiate(shopItemPrefeb);
            shopitem.transform.parent = content.transform;
            shopitem.GetComponentInChildren<ShopItems>().SetItem(itemDB[i]);
            shopitem.GetComponentsInChildren<ShopItems>()[1].SetItemDesc(itemDB[i]);
            shopitem.GetComponentsInChildren<ShopItems>()[2].ItemTypeMatch(itemDB[i]);
            shopitem.GetComponentsInChildren<ShopItems>()[3].SetItemGold(itemDB[i]);
            shopitem.GetComponentsInChildren<ShopItems>()[4].SetBuyItem(itemDB[i]);
        }
        for (int i = 0; i < 3; i++)
        {
            inventory.Add(itemDB[i]);
        }
        Debug.Log(inventory.Count);
        for (int i = 0; i < inventory.Count; i++)
        {
            GameObject inventoryitem = Instantiate(inventoryItemPrefeb);
            inventoryitem.transform.parent = content.transform;
            inventoryitem.GetComponentInChildren<ShopItems>().SetItem(inventory[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
