using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomPanel : MonoBehaviour
{
    [SerializeField] GameObject panel;
    // やること
    //アイテムを選択していたら
    //Zoomボタンが押されたら、パネルを表示する
    public void ShowPanel()
    {
        panel.SetActive(true);
        Item item = ItemBox.instance.GetSelectedItem();
        if (item != null)
        {
            panel.SetActive(true);
        }
    }
    //アイテムを表示
    //Closeボタンが押されたら、パネルを非表示
    public void ClosePanel()
    {
        panel.SetActive(false);
    }
}
