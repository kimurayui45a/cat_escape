using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject player;

    void Start()
    {
        this.player = GameObject.Find("player_0");
    }

    void Update()
    {
        // ����������ɏ������ړ�������
        transform.Translate(0, -0.1f, 0);

        // ���ʊO�iy = -5.0f �ȉ��j�ɏo����폜����
        if (transform.position.y < -5.0f)
        {
            // ����폜
            Destroy(gameObject);
        }

        // ��̈ʒu��2D�x�N�g���Ƃ��Ď擾
        Vector2 p1 = transform.position;

        // �v���C���[�̈ʒu��2D�x�N�g���Ƃ��Ď擾
        Vector2 p2 = this.player.transform.position;

        // ��ƃv���C���[�̋����x�N�g�����v�Z
        Vector2 dir = p1 - p2;

        // ��ƃv���C���[�̋����i�x�N�g���̒����j�����߂�
        float d = dir.magnitude;

        // ��̓����蔻�蔼�a
        float r1 = 0.5f;

        // �v���C���[�̓����蔻�蔼�a
        float r2 = 1.0f;

        // ��ƃv���C���[���������Ă��邩����i2�̉~�̋��������v���a��菬�����j
        if (d < r1 + r2)
        {
            // GameDirector �I�u�W�F�N�g���V�[��������T��
            GameObject director = GameObject.Find("GameDirector");

            // GameDirector �̃X�N���v�g���擾���AHP�����炷�֐����Ăяo��
            director.GetComponent<GameDirector>().DecreaseHp();

            Destroy(gameObject);
        }
    }
}
