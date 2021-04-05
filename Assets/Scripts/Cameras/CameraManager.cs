using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    // �J�����̐؂�ւ�
    //�ǂ��ɂǂ̃J������L���ɂ���̂�
    //�ǂ���
    //�Emain�̑S�̂���]����J����
    //�E�Y�[�������Ƃ��̃J����

    //�S�̂���]����J�����̃|�W�V�������쐬
    [SerializeField] Transform[] mainCameraTransforms = default;
    int currentMainPosition;
    void Start()
    {
        currentMainPosition = 0;
        Camera.main.transform.position = mainCameraTransforms[currentMainPosition].position;
        Camera.main.transform.rotation = mainCameraTransforms[currentMainPosition].rotation;
    }
    
    public void TurnLeft()
    {
        currentMainPosition--;
        if (currentMainPosition < 0)
        {
            currentMainPosition = mainCameraTransforms.Length -1;
        }
        Camera.main.transform.position = mainCameraTransforms[currentMainPosition].position;
        Camera.main.transform.rotation = mainCameraTransforms[currentMainPosition].rotation;
    }

    public void TurnRight()
    {
        currentMainPosition++;
        if (currentMainPosition >= mainCameraTransforms.Length)
        {
            currentMainPosition = 0;
        }
        Camera.main.transform.position = mainCameraTransforms[currentMainPosition].position;
        Camera.main.transform.rotation = mainCameraTransforms[currentMainPosition].rotation;
    }
}
