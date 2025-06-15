using UnityEngine;

public class CatCanController : MonoBehaviour
{
    GameObject player;

    void Start()
    {
        this.player = GameObject.Find("player_0");
    }

    void Update()
    {
        // �L�ʂ��������ɏ������ړ�������
        transform.Translate(0, -0.03f, 0);

        // �L�ʂ���ʊO�iy = -5.0f �ȉ��j�ɏo����폜����
        if (transform.position.y < -5.0f)
        {
            // �L�ʂ��폜
            Destroy(gameObject);
        }

        // �L�ʂ̈ʒu��2D�x�N�g���Ƃ��Ď擾
        Vector2 p1 = transform.position;

        // �v���C���[�̈ʒu��2D�x�N�g���Ƃ��Ď擾
        Vector2 p2 = this.player.transform.position;

        // �L�ʂƃv���C���[�̋����x�N�g�����v�Z
        Vector2 dir = p1 - p2;

        // �L�ʂƃv���C���[�̋����i�x�N�g���̒����j�����߂�
        float d = dir.magnitude;

        // �L�ʂ̓����蔻�蔼�a
        float r1 = 0.5f;

        // �v���C���[�̓����蔻�蔼�a
        float r2 = 1.0f;

        // �L�ʂƃv���C���[���������Ă��邩����i2�̉~�̋��������v���a��菬�����j
        if (d < r1 + r2)
        {
            // GameDirector �I�u�W�F�N�g���V�[��������T��
            GameObject director = GameObject.Find("GameDirector");

            // GameDirector �̃X�N���v�g���擾���AHP�𑝂₷�֐����Ăяo��
            director.GetComponent<GameDirector>().RecoveryHp();

            Destroy(gameObject);
        }
    }
}
