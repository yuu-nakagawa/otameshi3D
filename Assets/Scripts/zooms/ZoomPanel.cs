using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomPanel : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] Transform objPearent;
    GameObject zoomObj;

    private void Start()
    {
        panel.SetActive(false);
    }
    // やること
    //アイテムを選択していたら
    //Zoomボタンが押されたら、パネルを表示する
    public void ShowPanel()
    {
        Item item = ItemBox.instance.GetSelectedItem();
        if (item != null)
        {
            Destroy(zoomObj);
            panel.SetActive(true);
            //アイテムを表示
            //ObjParentにアイテムを生成する
            GameObject zoomObjPrefab = ItemGenerater.instance.GetZoomItem(item.type);
            zoomObj = Instantiate(zoomObjPrefab, objPearent);
        }
    }
    //アイテムを表示
    //Closeボタンが押されたら、パネルを非表示
    public void ClosePanel()
    {
        panel.SetActive(false);
        Destroy(zoomObj);
    }
}
