using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject inventoryPanel;
    public GameObject shopPanel;
    public GameObject statsPanel;

    public Text playerName;
    public Text playerLevel;
    public Text playerDesc;

    bool isActiveInventoryPanel = false;
    bool isActiveShopPanel = false;
    bool isActiveStatsPanel = false;

    // Start is called before the first frame update
    void Start()
    {
        inventoryPanel.SetActive(false);
        shopPanel.SetActive(false);
        inventoryPanel.SetActive(false);

        playerName.text = PlayerManager.playerName;
        playerLevel.text = "Level : " + PlayerManager.playerLevel.ToString();
        playerDesc.text = PlayerManager.playerDesc;

    }

    public void MainBtnOnClick(GameObject panel)
    {
        panel.SetActive(true);
    }

    public void EscapePanelOnClick(GameObject panel)
    {
        panel.SetActive(false);
    }
}
