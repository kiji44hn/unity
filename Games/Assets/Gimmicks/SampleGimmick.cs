using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleGimmick : MonoBehaviour
{
    // アイテムCubeを持っている状態で、クリックすると消える
    // クリック判定
    // アイテムを持っている判定

    [SerializeField] Item.Type clearItem;

    public void OnClickObj()
    {
        Debug.Log("OnClickObj");
        // アイテムCubeを持っているかどうか
        bool gimmickClear = ItemBox.instance.TryUseItem(clearItem);
        if (gimmickClear == true)
        {
            Debug.Log("ギミックを解除");
            gameObject.SetActive(false);
        }
    }
}
