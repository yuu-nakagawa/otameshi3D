using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    //Slotが空いてたら、左から入れていく
    [SerializeField] Slot[] slots;
    //どこでも実行できるやつ
    public static ItemBox instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    //PickupObjがクリックされたら、スロットにアイテムを入れる
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
