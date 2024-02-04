using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    DataManager dataManager;

    public static float atk = 35;
    public static float def = 40;
    public static float hp = 100;
    public static float cri = 25;
    public static string playerName = "2hys";

    //
    public static int gold = 100;
    public static int level;
    public static float exp;
    private void Awake()
    {
        dataManager = GetComponent<DataManager>();
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
