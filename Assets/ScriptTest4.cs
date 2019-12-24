using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTest4 : MonoBehaviour 
{
    /*
     * 配列について
     * 配列とは: 複数のデータを（連続的に）まとめたもの
     * 宣言方法と代入    
     * 配列の要素の個数(長さ)を取得する方法    
     */

    int playerHP = 100;
    string mapType = "trap";
     
	// はじめに１回実行される処理
	void Start () 
    {
        string user0 = "藤原";
        string user1 = "スタジオ";
        string user2 = "祐哉";
        string user3 = "yuya";
        string user4 = "中澤";
        //配列の宣言方法と代入
        //宣言
        string[] users = new string[5];　　　　　　　　　　　　　　　　
        //以下代入
        users[0] = "藤原";
        users[1] = "スタジオ";
        users[2] = "祐哉";
        users[3] = "yuya";
        users[4] = "中澤";
        // Debug.Log(users);
        // Debug.Log(users[0]);//取得方法
        // Debug.Log(users[3]);
        //宣言と同時に代入
        int[] numbers = { -1, 2, 34, 5, -123, -1, 2, 34, 5, -123 };
        // int[] numbers_aa = new int[5]{ -1 , 2 , 34, -123 };
        // Debug.Log(numbers[3]);
        // debug.Log(numbers[-1]); //マイナスはダメ
        // Debug.Log(numbers[100]);　//範囲外なのでダメ
        // 配列の要素の個数(長さ)を取得する方法
        //Debug.Log(users.Length);
        //Debug.Log(numbers.Length);

        //よく似たものリスト
        List<int> numberList = new List<int>();
        numberList.Add(10);　//後から要素を追加できる
        numberList.Add(-10);
        //Debug.Log(numberList[0]);
        //Debug.Log(numberList[1]);
    }

    // Update is called once per frame
    void Update () 
    {
		
	}
}
