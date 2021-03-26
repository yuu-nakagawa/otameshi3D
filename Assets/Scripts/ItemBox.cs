using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    //Slot���󂢂Ă���A���������Ă���
    [SerializeField] Slot[] slots;
    //�ǂ��ł����s�ł�����
    public static ItemBox instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    //PickupObj���N���b�N���ꂽ��A�X���b�g�ɃA�C�e��������
    public void SetItem(Item item)
    {
        foreach (Slot slot in slots)
        {
            if (slot.IsEmpty())
            {
                slot.SetItem(item);
                break;
            }
        }
        /*
        if (slots[0].IsEmpty())
        {
            slots[0].SetItem(item);
        }
        else if (slots[1].IsEmpty())
        {
            slots[1].SetItem(item);
        }
        else if (slots[2].IsEmpty())
        {
            slots[3].SetItem(item);
        }
        */
        //Debug.Log(item.type);
    }
}
