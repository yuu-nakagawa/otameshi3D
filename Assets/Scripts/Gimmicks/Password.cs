using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Password : MonoBehaviour
{
    //��������ƁA�O���̊֐������s����(UnityEvent)
    public UnityEvent ClearEvent;
    //����
    [SerializeField] int[] correctNumbers;
    //���݂̐��l:PasswordButton��Number������΂���
    [SerializeField] PasswordButton[] passwordButtons;

    // �N���b�N����x�Ɍ��݂̃p�l���̐��l�Ɛ������r
    //��v����Ȃ�N���A���O

    public void CheckClear()
    {
        if (IsClear())
        {
            Debug.Log("�N���A");
            ClearEvent.Invoke();
        }
    }

    bool IsClear()
    {
        //�������Ă��邩�ǂ���
        //=>1�ł���v���Ȃ����false
        //=>�S�Ẵ`�F�b�N���N���A�����true
        for (int i=0; i< correctNumbers.Length; i++)
        {
            if (passwordButtons[i].number != correctNumbers[i])
            {
                return false;
            }
        }
        return true;
        /*
        if ((passwordButtons[0].number == correctNumbers[0])
            && (passwordButtons[1].number == correctNumbers[1])
            && (passwordButtons[2].number == correctNumbers[2])
            && (passwordButtons[3].number == correctNumbers[3]))
            {
              return true;
             }
        return false;
        */
    }    
}
