using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    // どこでも実行できる
    public static ItemBox instance;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // PickupObjがクリックされたら、スロットにアイテムを入れる

    public void SetItem()
    {
        Debug.Log("SetItem");
    }
}
