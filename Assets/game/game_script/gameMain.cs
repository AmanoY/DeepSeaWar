using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameMain : MonoBehaviour
{
    [HideInInspector]
    public float gameDeltaTime;//ゲームスピードを考慮した1fの時間
    [SerializeField]
    private float playSpeed; //ゲームの速度、アイテムとかスキルで増減させるかな
    public float costMax, costValue, costUpVec; //持てるコストの最大値,現在のコスト所持
    private int[] partyChara; //パーティーのキャラ編成

    //UI関連のオブジェクト
    public Text costTxt;
    void Start()
    {

    }

    void Update()
    {
        //毎フレーム最初にgamespeedを考慮したdeltatimeを算出
        gameDeltaTime = Time.deltaTime * playSpeed;

        //コスト上昇処理
        costValue += costUpVec * gameDeltaTime;
        costTxt.text = costValue.ToString("000.00");
    }

    void levelUp()
    {
    }
}
