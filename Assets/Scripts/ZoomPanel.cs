using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomPanel : MonoBehaviour
{
    [SerializeField] GameObject panel;
    // ��邱��
    //�A�C�e����I�����Ă�����
    //Zoom�{�^���������ꂽ��A�p�l����\������
    public void ShowPanel()
    {
        panel.SetActive(true);
        Item item = ItemBox.instance.GetSelectedItem();
        if (item != null)
        {
            panel.SetActive(true);
        }
    }
    //�A�C�e����\��
    //Close�{�^���������ꂽ��A�p�l�����\��
    public void ClosePanel()
    {
        panel.SetActive(false);
    }
}
