using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    #region Singleton
    public static PlayerManager instance;
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
    }
    #endregion
    [SerializeField]
    public static float atk = 35;
    public static float def = 40;
    public static float hp = 100;
    public static float cri = 25;
    public static string playerName = "Chad";
    public static string playerDesc = "피곤한 상태입니다.";

    public static float addedAtk = 0;
    public static float addedDef = 0;
    //
    [SerializeField] public static int gold = 1500;
    public static int playerLevel = 1;
    public static float exp;


    public void StatUpdate()
    {
        for(int i = 0; i < Inventory.instance.inventory.Count; i++)
        {
            Debug.Log(Inventory.instance.inventory[i].Name + "의 장착을 확인중");
            Debug.Log(Inventory.instance.inventory[i].Desc + " : 설명");
            if (Inventory.instance.inventory[i].isEquied == true)
            {
                Debug.Log(Inventory.instance.inventory[i].Name + "의 장착을 확인함. 스텟 적용");
                addedAtk = Inventory.instance.inventory[i].Atk;
            }
            else
            {
                addedAtk = 0;
                Debug.Log(Inventory.instance.inventory[i].Name + "은 장착중이지 않음.");
            }
        }
        Debug.Log(atk);
        UIManager.instance.UIUpdate();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
