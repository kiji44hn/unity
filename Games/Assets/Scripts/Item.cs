using System;
using UnityEngine;

[Serializable]
public class Item
{
    // 列挙型：アイテムの種類を列挙する
    public enum　Type
    {
        Cube,
        Ball,
    }

    public Type type;             // 種類
    public Sprite sprite;         // Slotに表示する画像
    public GameObject zoomObj;

    public Item(Type type, Sprite sprite, GameObject zoomObj)
    {
        this.type = type;
        this.sprite = sprite;
        this.zoomObj = zoomObj;
    }
}
