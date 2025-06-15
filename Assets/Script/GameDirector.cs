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

    // HPを補正してゲージを更新する共通処理
    void UpdateHpDisplay()
    {
        // マイナスにならないように補正
        this.hp = Mathf.Max(hp, 0);

        // Hpの割合を代入、UIを更新
        this.hpGauge.GetComponent<Image>().fillAmount = hp / 100.0f;

        //this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
        //this.hp -= 10;
    }


    public void DecreaseHp()
    {

        // hp を 10 減らす（数値でHP管理）
        this.hp -= 10;

        // 共通処理
        UpdateHpDisplay();

        if (hp <= 0)
        {
            GameObject player = GameObject.Find("player_0");

            // スプライトをお墓に差し替え
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

        // hp を 10 減らす（数値でHP管理）
        this.hp += 10;

        // 共通処理
        UpdateHpDisplay();

    }

}
