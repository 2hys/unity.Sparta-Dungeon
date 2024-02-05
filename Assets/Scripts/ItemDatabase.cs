using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemDatabase : MonoBehaviour
{
    public static ItemDatabase instance;

    //����ǵ�����.. ����Ʈ �ǵ�� �ʱ�ȭ��..
    public List<Item> itemDB = new List<Item>();
    //public List<Item> inventory = new List<Item>();

    public GameObject shopItemPrefeb;
    public GameObject content;

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;

        for (int i = 0; i < 3; i++)
        {
            GameObject shopitem = Instantiate(shopItemPrefeb);
            shopitem.transform.parent = content.transform;
            shopitem.GetComponentInChildren<ShopItems>().SetItem(itemDB[i]);
            shopitem.GetComponentsInChildren<ShopItems>()[1].SetItemDesc(itemDB[i]);
            shopitem.GetComponentsInChildren<ShopItems>()[2].ItemTypeMatch(itemDB[i]);
            shopitem.GetComponentsInChildren<ShopItems>()[3].SetItemGold(itemDB[i]);

            //������ ����
            shopitem.GetComponentsInChildren<ShopItems>()[4].SetItemBuyBtn(itemDB[i]);
        }
        //test��
        for (int i = 0; i < 3; i++)
        {
            //inventory.Add(itemDB[i]);
            Inventory.instance.AddItem(itemDB[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
