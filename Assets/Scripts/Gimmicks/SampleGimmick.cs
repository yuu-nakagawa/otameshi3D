using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleGimmick : MonoBehaviour
{
    // ��肽������
    //�A�C�e��Cube�������Ă����ԂŁA�N���b�N����Ə�����
    //�E�N���b�N����
    //�E�A�C�e�������Ă܂��攻��

    public void OnClickObj()
    {
        Debug.Log("�N���b�N������");
        //�A�C�e��Cube�������Ă��邩�ǂ���
        bool clear = ItemBox.instance.TryUseItem();
        if (clear == true)
        {
            Debug.Log("�M�~�b�N����");
            gameObject.SetActive(false);
        }
    }
}

