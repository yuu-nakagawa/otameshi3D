using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    //�A�C�e��(�f�[�^)���󂯎�邽�߂ɕϐ���p�ӂ���
    Item item;
    // �A�C�e�����󂯎������摜���X���b�g�ɕ\�����Ă��
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
        //�A�C�e��(�f�[�^)����������
        this.item = item;
        UpdateImage(item);
    }

    void UpdateImage(Item item)
    {
        image.sprite = item.sprite;
    }
}
