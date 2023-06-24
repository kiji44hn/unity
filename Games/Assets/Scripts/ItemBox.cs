using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    // Slotが空いていたら、左から入れていく


    [SerializeField] Slot[] slots;
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

    public void SetItem(Item item)
    {
        foreach (Slot slot in slots)
        {
            if (slot.IsEmpty())
            {
                slot.SetItem(item);
                break;
            }
        }
        /*
        if (slots[0].IsEmpty())
        {
            slots[0].SetItem(item);
        }
        else if (slots[1].IsEmpty())
        {
            slots[1].SetItem(item);
        }
        else if (slots[2].IsEmpty())
        {
            slots[2].SetItem(item);
        }
        else if (slots[3].IsEmpty())
        {
            slots[3].SetItem(item);
        }
        else
        {
            slots[4].SetItem(item);
        }
        */
    }
}
