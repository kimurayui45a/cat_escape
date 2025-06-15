using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject hpGauge;
    int hp = 100;

    public Sprite ohakaSprite;

    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
    }

    // HP��␳���ăQ�[�W���X�V���鋤�ʏ���
    void UpdateHpDisplay()
    {
        // �}�C�i�X�ɂȂ�Ȃ��悤�ɕ␳
        this.hp = Mathf.Max(hp, 0);

        // Hp�̊��������AUI���X�V
        this.hpGauge.GetComponent<Image>().fillAmount = hp / 100.0f;

        //this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
        //this.hp -= 10;
    }


    public void DecreaseHp()
    {

        // hp �� 10 ���炷�i���l��HP�Ǘ��j
        this.hp -= 10;

        // ���ʏ���
        UpdateHpDisplay();

        if (hp <= 0)
        {
            GameObject player = GameObject.Find("player_0");

            // �X�v���C�g������ɍ����ւ�
            if (player != null)
            {
                SpriteRenderer sr = player.GetComponent<SpriteRenderer>();
                if (sr != null && ohakaSprite != null)
                {
                    sr.sprite = ohakaSprite;
                }
            }
        }
    }

    public void RecoveryHp()
    {

        // hp �� 10 ���炷�i���l��HP�Ǘ��j
        this.hp += 10;

        // ���ʏ���
        UpdateHpDisplay();

    }

}
