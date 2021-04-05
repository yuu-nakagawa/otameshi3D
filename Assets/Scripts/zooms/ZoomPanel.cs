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
    // ��邱��
    //�A�C�e����I�����Ă�����
    //Zoom�{�^���������ꂽ��A�p�l����\������
    public void ShowPanel()
    {
        Item item = ItemBox.instance.GetSelectedItem();
        if (item != null)
        {
            Destroy(zoomObj);
            panel.SetActive(true);
            //�A�C�e����\��
            //ObjParent�ɃA�C�e���𐶐�����
            GameObject zoomObjPrefab = ItemGenerater.instance.GetZoomItem(item.type);
            zoomObj = Instantiate(zoomObjPrefab, objPearent);
        }
    }
    //�A�C�e����\��
    //Close�{�^���������ꂽ��A�p�l�����\��
    public void ClosePanel()
    {
        panel.SetActive(false);
        Destroy(zoomObj);
    }
}
