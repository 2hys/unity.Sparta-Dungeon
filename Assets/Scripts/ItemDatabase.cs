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

    public GameObject shopItemPrefeb;
    

    // Start is called before the first frame update
    void Start()
    {
        foreach (Item item in itemDB)
        {
            //shopItemPrefeb...�� ��ġ�ǰԲ�? �� ���� ������ ��ġ�Ұ͵� �ƴѵ�..?
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
