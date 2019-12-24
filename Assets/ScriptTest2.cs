using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTest2 : MonoBehaviour
{
    　/*　演算子
    　*　四則演算子: + - * / %
   　 *　比較演算:  < > >= <= != ==  : trueかfalseが返ってくる
      *　インクリメント,デクリメント　: ++, --
      */

	// Use this for initialization
	void Start ()
    {
        /*
		int x = 8 + 2; //10
        int y = 2;       //2
        int z = x - y;    // 10 - 2:8
        */       
        /*
        Debug.Log(z);
        Debug.Log(x * y);
        Debug.Log(x / y);
        Debug.Log(x % y); // xをyで割ったあまり　2の倍数、3の倍数(重要)
        string Name = "藤原"+"祐哉";  //文字列の足す場合
        Debug.Log(Name);
        Debug.Log("HP:" + z);
        */
        // 比較演算子は、if文に良く使う(アイテムなのか敵なのかを判断させたりする時など)
        /*
        Debug.Log(2 >= 1);  //2は1以上
        Debug.Log(2 <= 1);　//2は1以下　
        Debug.Log(2 != 1);　//2は1が違う
        Debug.Log(2 == 1);  //2と1が等しい   
        */
        //省略記号がある
        //int x = 0;
        //x = x - 1;  //0+1;
        //Debug.Log(x);  // 1
        //x -= 1; 　　　　// 1+1:2
        //Debug.Log(x);
        //x --;         //2+1
        //Debug.Log(x);
    }
	　　//次回　if文

	// Update is called once per frame
	void Update () 
    {
		
	}
}
