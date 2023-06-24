using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    // slotsにslot要素をコードから入れる
    [SerializeField] Slot[] slots;
    [SerializeField] Slot selectedSlot = null;

    // どこでも実行できる
    public static ItemBox instance;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
            slots = GetComponentsInChildren<Slot>();
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
    }

    public void OnSelectSlot(int position)
    {
        // 一旦、全てのスロットの選択パネルを非表示
        foreach (Slot slot in slots)
        {
            slot.HideBgPanel();
        }

        // 選択されたスロットの選択パネルを表示
        if (slots[position].OnSelected())
        {
            selectedSlot = slots[position];
        }
    }

    // アイテムの使用を試みる&使えるなら使ってしまう
    public bool TryUseItem(Item.Type type)
    {
        // 選択スロットがあるかどうか
        if (selectedSlot == null)
        {
            return false;
        }
        if (selectedSlot.GetItem().type == type)
        {
            selectedSlot.SetItem(null);
            selectedSlot.HideBgPanel();
            selectedSlot = null;
            return true;
        }
        return false;
    }
}
