using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    Item item;
    [SerializeField] Image image;
    [SerializeField] GameObject backGroundPanel;

    private void Awake()
    {
        // image = GetComponent<Image>();
    }

    public void Start()
    {
        backGroundPanel.SetActive(false);
    }

    public bool IsEmpty()
    {
        if (item == null)
        {
            return true;
        }
        return false;
    }

    public void SetItem(Item item)
    {
        this.item = item;
        UpdateImage(item);
    }

    public Item GetItem()
    {
        return item;
    }

    void UpdateImage(Item item)
    {
        if (item == null)
        {
            image.sprite = null;
        }
        else
        {
            image.sprite = item.sprite;
        }
    }

    public bool OnSelected()
    {
        if (item == null)
        {
            return false;
        }
        backGroundPanel.SetActive(true);
        return true;
    }

    public void HideBgPanel()
    {
        backGroundPanel.SetActive(false);
    }
}
