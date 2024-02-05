using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    #region Singleton
    public static UIManager instance;
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;

        inventoryPanel.SetActive(false);
        shopPanel.SetActive(false);
        statsPanel.SetActive(false);
    }
    #endregion
    public GameObject inventoryPanel;
    public GameObject shopPanel;
    public GameObject statsPanel;


    public Text playerAtk;
    public Text playerDef;
    public Text playerHp;
    public Text playerCri;

    public Text playerName;
    public Text playerLevel;
    public Text playerDesc;
    public Text playerGold;

    bool isActiveInventoryPanel = false;
    bool isActiveShopPanel = false;
    bool isActiveStatsPanel = false;

    // Start is called before the first frame update
    void Start()
    {


        UIUpdate();
}

    public void MainBtnOnClick(GameObject panel)
    {
        panel.SetActive(true);
    }

    public void EscapePanelOnClick(GameObject panel)
    {
        panel.SetActive(false);
    }
    public void UIUpdate()
    {
        playerName.text = PlayerManager.playerName;
        playerLevel.text = "Level : " + PlayerManager.playerLevel.ToString();
        playerDesc.text = PlayerManager.playerDesc;
        playerGold.text = PlayerManager.gold.ToString();

        playerAtk.text = PlayerManager.atk.ToString("F0");
        playerDef.text = PlayerManager.def.ToString("F0");
        playerHp.text = PlayerManager.hp.ToString("F0");
        playerCri.text = PlayerManager.cri.ToString("F0");
    }
}
