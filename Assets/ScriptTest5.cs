using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTest5 : MonoBehaviour 
{
    /*  while文について
     *　while文とは、条件があっている間、繰り返し処理を実行する
     *  break; // 繰り返し処理を終了する
     * continue　/処理を飛ばす
     */

    // はじめに１回実行される処理
    void Start () 
    {
        string[] users = new string[6];
        //以下代入
        users[0] = "藤原";
        users[1] = "スタジオ";
        users[2] = "祐哉";
        users[3] = "yuya";
        users[4] = "中澤";
        users[5] = "nakazawa";
        int[] numbers = { -1, 2, 34, 5, -123, -1, 2, 34, 5, -123 };

        int count = 0;
        /*
        while (count < users.Length) //条件
        {
            if (count == 2)
            {
                count++;
                continue; // 繰り返し処理を終了する
            }
            Debug.Log("処理" + users[count]);
            count++; // count = count + 1;
        }
        */
        for (int i  = 0; i< users.Length; i++)
        {
            if (i == 2)
            {
                continue;  // 繰り返し処理を終了する
            }
            Debug.Log("処理" + users[i]);
        }
    }
	
	// Update is called once per frame
	void Update () 
    {
		
	}
}
