using UnityEngine;

public class CatCanGenerator : MonoBehaviour
{
    // �L�ʂ̃v���n�u��Inspector����w�肷�邽�߂̕ϐ�
    public GameObject catCanPrefab;

    // �L�ʂ𐶐�����Ԋu(�b)
    float span = 3.0f;

    // ���Ԃ̌o�߂��L�^����ϐ�
    float delta = 0;

    void Update()
    {
        // �O�̃t���[������o�߂������Ԃ����Z���Ă���
        this.delta += Time.deltaTime;

        // span �b�ȏ�o���������`�F�b�N
        if (this.delta > this.span)
        {
            // �o�ߎ��Ԃ����Z�b�g�A���̐����܂ł̃J�E���g���J�n
            this.delta = 0;

            // �L�ʂ̃v���n�u�𕡐��A�V�����L�ʂ𐶐�
            GameObject go = Instantiate(catCanPrefab);

            // -6�`6 �̊ԂŃ����_���Ȑ����𐶐��AX���W�������_���ɂ���
            int px = Random.Range(-6, 7);

            // �L�ʂ̏����ʒu��ݒ�A��̕��ɕ\���A�������̓����_��
            go.transform.position = new Vector3(px, 7, 0);
        }
    }
}
