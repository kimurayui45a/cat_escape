using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    // 矢のプレハブをInspectorから指定するための変数
    public GameObject arrowPrefab;

    // 矢を生成する間隔(秒)
    float span = 1.0f;

    // 時間の経過を記録する変数
    float delta = 0;

    void Update()
    {
        // 前のフレームから経過した時間を加算していく
        this.delta += Time.deltaTime;

        // span 秒以上経ったかをチェック
        if (this.delta > this.span)
        {
            // 経過時間をリセット、次の生成までのカウントを開始
            this.delta = 0;

            // 矢のプレハブを複製、新しい矢を生成
            GameObject go = Instantiate(arrowPrefab);

            // -6～6 の間でランダムな整数を生成、X座標をランダムにする
            int px = Random.Range(-6, 7);

            // 矢の初期位置を設定、上の方に表示、横方向はランダム
            go.transform.position = new Vector3(px, 7, 0);
        }
    }
}
