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

    public static float atk = 35;
    public static float def = 40;
    public static float hp = 100;
    public static float cri = 25;
    public static string playerName = "Chad";
    public static string playerDesc = "피곤한 상태입니다.";

    //
    public static int gold = 500;
    public static int playerLevel = 1;
    public static float exp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
