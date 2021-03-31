using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    //アイテム(データ)を受け取るために変数を用意する
    Item item;
    // アイテムを受け取ったら画像をスロットに表示してやる
    [SerializeField] Image image;
    [SerializeField] GameObject backgroundPanel;
    private void Awake()
    {
        //image = GetComponent<Image>();
    }

    private void Start()
    {
        backgroundPanel.SetActive(false);
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
        //アイテム(データ)を持たせる
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
        backgroundPanel.SetActive(true);
        return true;
    }

    public void HideBGPanel()
    {
        backgroundPanel.SetActive(false);
    }
}
