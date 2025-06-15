using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    void Start()
    {
        // フレームレートを60FPSに固定
        Application.targetFrameRate = 60;
    }

    // 左ボタンを押したときに左へ移動する処理
    public void LButtonDown()
    {
        // X方向に-3移動
        transform.Translate(-3, 0, 0);
    }

    // 右ボタンを押したときに右へ移動する処理
    public void RButtonDown()
    {
        // X方向に+3移動
        transform.Translate(3, 0, 0);
    }

    void Update()
    {
        // 左矢印キーが押された瞬間
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // 左へ3移動
            transform.Translate(-3, 0, 0);
        }

        // 右矢印キーが押された瞬間
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            // 右へ3移動
            transform.Translate(3, 0, 0);
        }
    }
}
