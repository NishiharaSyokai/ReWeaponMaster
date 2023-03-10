using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSVProcessing : MonoBehaviour
{
    //      ※アセットCSVSERIALIZERが必要デス

    //      モンスターのステータス
    public MonsterData[] monsterData;

    //      プレイヤーの武器のステータス
    public PlayerWeapon[] playerWeapons;

    // Start is called before the first frame update
    void Start()
    {
        //      テキストファイルの読み込みを行って繰れるクラス
        TextAsset textasset = new TextAsset();

        //      モンスターのステータスをCSVから受けとる
        EnemyStatas(textasset);

        //      テキストファイルの読み込みを行って繰れるクラス
        TextAsset textasse = new TextAsset();

        //      武器のステータスをCSVから受け取る
        PlayerWeapon(textasset);
    }

    // Update is called once per frame
    void Update()
    {
        //      データはどこでも呼び出し可能にできる
        //int a = monsterData[0].ATK;
    }

    private void EnemyStatas(TextAsset textasset)
    {
        //      ファイルを探しその中のCSVを読み込む
        textasset = Resources.Load("jabu", typeof(TextAsset)) as TextAsset;

        //      CSVファイルを配列に入れる
        monsterData = CSVSerializer.Deserialize<MonsterData>(textasset.text);
    }

    private void PlayerWeapon(TextAsset textasset)
    {
        //      ファイルを探しその中のCSVを読み込む
        textasset = Resources.Load("weapon", typeof(TextAsset)) as TextAsset;

        //      CSVファイルを配列に入れる
        playerWeapons = CSVSerializer.Deserialize<PlayerWeapon>(textasset.text);
    }
}
