using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    void Start()
    {
        // �t���[�����[�g��60FPS�ɌŒ�
        Application.targetFrameRate = 60;
    }

    // ���{�^�����������Ƃ��ɍ��ֈړ����鏈��
    public void LButtonDown()
    {
        // X������-3�ړ�
        transform.Translate(-3, 0, 0);
    }

    // �E�{�^�����������Ƃ��ɉE�ֈړ����鏈��
    public void RButtonDown()
    {
        // X������+3�ړ�
        transform.Translate(3, 0, 0);
    }

    void Update()
    {
        // �����L�[�������ꂽ�u��
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // ����3�ړ�
            transform.Translate(-3, 0, 0);
        }

        // �E���L�[�������ꂽ�u��
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            // �E��3�ړ�
            transform.Translate(3, 0, 0);
        }
    }
}
