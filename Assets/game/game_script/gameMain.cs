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
    private int[] partyChara = new int[10]; //パーティーのキャラ編成

    [SerializeField]
    private GameObject charaBase;
    //UI関連のオブジェクト
    public Text costTxt,maxTxt;
    void Start()
    {
        maxTxt.text = "MAX " + costMax.ToString("000.00");
    }

    void Update()
    {
        //毎フレーム最初にgamespeedを考慮したdeltatimeを算出
        gameDeltaTime = Time.deltaTime * playSpeed;

        //コスト上昇処理
        if(costValue < costMax) costValue += costUpVec * gameDeltaTime;
        else costValue = costMax; //最大値で止める
        costTxt.text = costValue.ToString("000.00"); //表示変更
    }

    void levelUp()
    {
    }

    //キャラ生成呼び出し
    public void generate(int windPosNum)
    {
        costValue -= 2.5f;
        GameObject geneObj = Instantiate(charaBase) as GameObject;
        geneObj.GetComponent<charaDataLoad>().loadData(partyChara[windPosNum]);
    }
}
