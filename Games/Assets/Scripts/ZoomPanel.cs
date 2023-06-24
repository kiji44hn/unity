using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomPanel : MonoBehaviour
{
    [SerializeField] GameObject panel;

    // アイテムを選択時
    // Zoomボタン押下後、パネルを表示
    public void ShowPanel()
    {
        Item item = ItemBox.instance.GetSelectedItem();
        if (item != null)
        {
            panel.SetActive(true);
        }

    }
    // アイテムを表示
    // Closeボタン押下後、パネルを非表示
    public void ClosePanel()
    {
        panel.SetActive(false);

    }
}
