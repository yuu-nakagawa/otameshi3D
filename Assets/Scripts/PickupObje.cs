using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObje : MonoBehaviour
{
    //�N���b�N�����烍�O���o��
    //[SerializeField] Item.Type item;
    [SerializeField] Item item;
    public void OnClickObj()
    {
        ItemBox.instance.SetItem(item);
        gameObject.SetActive(false);
    }
}
