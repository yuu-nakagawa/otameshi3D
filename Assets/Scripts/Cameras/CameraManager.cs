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

    Camera currentCamera;
    Camera mainCamera;

    //�ǂ̃t�@�C������ł��֐������s�ł���
    public static CameraManager instance;
    private void Awake()
    {
        instance = this;
    }

    //�S�̂���]����J�����̃|�W�V�������쐬
    [SerializeField] Transform[] mainCameraTransforms = default;
    int currentMainPosition;
    void Start()
    {
        mainCamera = Camera.main;
        currentCamera = Camera.main;
        currentMainPosition = 0;
        currentCamera.transform.position = mainCameraTransforms[currentMainPosition].position;
        currentCamera.transform.rotation = mainCameraTransforms[currentMainPosition].rotation;
    }
    
    public void TurnLeft()
    {
        currentMainPosition--;
        if (currentMainPosition < 0)
        {
            currentMainPosition = mainCameraTransforms.Length -1;
        }
        currentCamera.transform.position = mainCameraTransforms[currentMainPosition].position;
        currentCamera.transform.rotation = mainCameraTransforms[currentMainPosition].rotation;
    }

    public void TurnRight()
    {
        currentMainPosition++;
        if (currentMainPosition >= mainCameraTransforms.Length)
        {
            currentMainPosition = 0;
        }
        currentCamera.transform.position = mainCameraTransforms[currentMainPosition].position;
        currentCamera.transform.rotation = mainCameraTransforms[currentMainPosition].rotation;
    }

    public void SetZoomCamera(Camera camera)
    {
        currentCamera.gameObject.SetActive(false);
        camera.gameObject.SetActive(true);
        currentCamera = camera;
    }
    public void OnBackButton()
    {
        mainCamera.gameObject.SetActive(true);
        currentCamera.gameObject.SetActive(false);
        currentCamera = mainCamera;
    }
}
