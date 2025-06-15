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
        // 矢を下方向に少しずつ移動させる
        transform.Translate(0, -0.1f, 0);

        // 矢が画面外（y = -5.0f 以下）に出たら削除する
        if (transform.position.y < -5.0f)
        {
            // 矢を削除
            Destroy(gameObject);
        }

        // 矢の位置を2Dベクトルとして取得
        Vector2 p1 = transform.position;

        // プレイヤーの位置を2Dベクトルとして取得
        Vector2 p2 = this.player.transform.position;

        // 矢とプレイヤーの距離ベクトルを計算
        Vector2 dir = p1 - p2;

        // 矢とプレイヤーの距離（ベクトルの長さ）を求める
        float d = dir.magnitude;

        // 矢の当たり判定半径
        float r1 = 0.5f;

        // プレイヤーの当たり判定半径
        float r2 = 1.0f;

        // 矢とプレイヤーが当たっているか判定（2つの円の距離が合計半径より小さい）
        if (d < r1 + r2)
        {
            // GameDirector オブジェクトをシーン内から探す
            GameObject director = GameObject.Find("GameDirector");

            // GameDirector のスクリプトを取得し、HPを減らす関数を呼び出す
            director.GetComponent<GameDirector>().DecreaseHp();

            Destroy(gameObject);
        }
    }
}
