using UnityEngine;
using System.Collections;

public class Str2 : MonoBehaviour
{
    // 名前：ドラ
    // 身長：200.0cm
    // 体重：120.0kg
    // 誕生日：7月35日
    string myName = "ドラ";
    float height = 200.0f;
    float weight = 120.0f;
    int monthOfbirth = 7;
    int dayOfbirth = 35;

    void Start()
    {
        Debug.Log("名前：" + myName);
        Debug.Log("身長：" + height);
        Debug.Log("体重：" + weight);
        Debug.Log("誕生日：" + monthOfbirth + "月" + dayOfbirth + "日");
    }
}
