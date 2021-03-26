using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    //アイテム(データ)を受け取るために変数を用意する
    Item item;
    // アイテムを受け取ったら画像をスロットに表示してやる
    Image image;

    private void Awake()
    {
        image = GetComponent<Image>();
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

    void UpdateImage(Item item)
    {
        image.sprite = item.sprite;
    }
}
