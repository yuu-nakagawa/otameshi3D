using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    //slots��slot�v�f���R�[�h����������@

    //Slot���󂢂Ă���A���������Ă���
    [SerializeField] Slot[] slots;
    [SerializeField]Slot selectiedSlot = null;
    //�ǂ��ł����s�ł�����
    public static ItemBox instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            slots = GetComponentsInChildren<Slot>();
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
    }

    public void OnSelectSlot(int position)
    {
        //��U�S�ẴX���b�g�̑I���p�l�����\��
        foreach (Slot slot in slots)
        {
            slot.HideBGPanel();
        }
        //�I�����ꂽ�X���b�g�̑I���p�l����\��
        if (slots[position].OnSelected())
        {
            selectiedSlot = slots[position];
        }
        
    }
}
