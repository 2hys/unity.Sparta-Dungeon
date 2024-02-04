using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static DataManager;

public class DataManager : MonoBehaviour
{











    // Scene이 바뀐다던가 해도 유지해야하는 데이터
    public class Player
    {
        //이번 프로젝트에서 Player의 데이터가 저장될 필요는 없지만
        //추후에는 Player의 Lv, name등 저장될 필요 있음.
        //
        public static float atk = 35;
        public static float def = 40;
        public static float hp = 100;
        public static float cri = 25;
        public static string playerName = "2hys";

        //
        public static int gold = 100;
        public static int level;
        public static float exp;

    }

}