using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTest : MonoBehaviour 
{

    //プログラムとの対話方法
    //変数とは何か？=＞箱：一時的にデータを記憶しておくもの
    //変数の使い方(宣言方法)
    //代入方法

    //データ型：変数の種類
    //文字列：string  :"こんにちは"
    //整数: int      : 1,2,-1,0
    //浮動少数点数　:float : 0.1f, -0.5f
    //論理値 : bool : true, false

    // Use this for initialization １回実行される
    void Start () 
    {
         //文字列
          string say;               //変数の宣言 : データ型　変数名
          say =　"こんにちは";        //代入
       　 //Debug.Log(say);           //sayという変数には何が入っているのかを調べる

          string sya2 = "おはよ";
          //Debug.Log(sya2);

          //データ型    C#は人に優しいし分かりやすい　C#以外のJavaScriptとかは、変数名などは関係がない　
          int n = 0;
          float f = 0.1f;
          bool isCat = false;
          //Debug.Log(n);
          //Debug.Log(f);
          //Debug.Log(isCat);

    }
	
	// Update is called once per frame　おおよそ0.02秒に１回呼ばれる
	void Update ()
    {
		
	}
}
