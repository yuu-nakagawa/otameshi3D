using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetObj : MonoBehaviour
{
    [SerializeField] GameObject setObject;
    [SerializeField] Item.Type useItem;
    //�K�؂ȃA�C�e����I��������Ԃ�
    // ���̃I�u�W�F�N�g���N���b�N������
    public void OnClickThis()
    {
        bool hasItem = ItemBox.instance.TryUseItem(useItem);
        if (hasItem)
        {
            //�A�C�e����\������
            setObject.SetActive(true);
        }        
    }    
}
