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
        // 猫缶を下方向に少しずつ移動させる
        transform.Translate(0, -0.03f, 0);

        // 猫缶が画面外（y = -5.0f 以下）に出たら削除する
        if (transform.position.y < -5.0f)
        {
            // 猫缶を削除
            Destroy(gameObject);
        }

        // 猫缶の位置を2Dベクトルとして取得
        Vector2 p1 = transform.position;

        // プレイヤーの位置を2Dベクトルとして取得
        Vector2 p2 = this.player.transform.position;

        // 猫缶とプレイヤーの距離ベクトルを計算
        Vector2 dir = p1 - p2;

        // 猫缶とプレイヤーの距離（ベクトルの長さ）を求める
        float d = dir.magnitude;

        // 猫缶の当たり判定半径
        float r1 = 0.5f;

        // プレイヤーの当たり判定半径
        float r2 = 1.0f;

        // 猫缶とプレイヤーが当たっているか判定（2つの円の距離が合計半径より小さい）
        if (d < r1 + r2)
        {
            // GameDirector オブジェクトをシーン内から探す
            GameObject director = GameObject.Find("GameDirector");

            // GameDirector のスクリプトを取得し、HPを増やす関数を呼び出す
            director.GetComponent<GameDirector>().RecoveryHp();

            Destroy(gameObject);
        }
    }
}
