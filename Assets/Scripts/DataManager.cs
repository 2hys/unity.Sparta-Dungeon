using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    // Scene�� �ٲ�ٴ��� �ص� �����ؾ��ϴ� ������
    public class Player
    {
        //�̹� ������Ʈ���� Player�� �����Ͱ� ����� �ʿ�� ������
        //���Ŀ��� Player�� Lv, name�� ����� �ʿ� ����.
        //
        public static float atk = 35;
        public static float def = 40;
        public static float hp = 100;
        public static float cri = 25;
        public static string playerName = "2hys";

        //
        public static int gold;
        public static int level;
        public static float exp;

    }

    // item
    public class Item
    {

    }
}