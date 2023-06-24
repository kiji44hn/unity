using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObj : MonoBehaviour
{
    [SerializeField] Item.Type item;
    // クリックしたら消す

    public void OnClickObj()
    {
        Debug.Log(item);
        ItemBox.instance.SetItem();
        gameObject.SetActive(false);
    }
}
