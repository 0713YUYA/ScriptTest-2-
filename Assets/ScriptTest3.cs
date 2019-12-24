using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTest3 : MonoBehaviour 
{
    /*
     * if文について
     * if文とは、条件に応じて処理を分けるもの
     * 
     * マップの種類によってプレイヤーのダメージを変える
     　*/
    int playerHP = 100;
    string mapType = "trap";

          
	// はじめに1回実行される処理
	void Start ()
    { 
       //マップの種類によってプレイヤーのダメージを変える
       //if(条件)
       if (mapType == "poison")
        {
            //条件がtrueなら処理をする
           //Debug.Log("playerは毒ダメージを受ける");
            playerHP -= 12;
        }
       else if(mapType == "trap")
        {
            //Debug.Log("playerはTrapダメージを受ける");
            playerHP -= 20;
        }
        else if (mapType == "Vocano")
        {
          　　//Debug.Log("playerはVocanoダメージを受ける");
            playerHP -= 100;
        }
        else
        {
            //　その他の処理
            Debug.Log("ダメージは受けない");
        }

       //-------switch文
       switch (mapType)
        {
            case "poison":
               // Debug.Log("playerは毒ダメージを受ける");
                playerHP -= 12;
                break;
            case "trap":
                //Debug.Log("playerはTrapダメージを受ける");
                playerHP -= 20;
                break;
            case "Volcano":
                //Debug.Log("playerはVocanoダメージを受ける");
                playerHP -= 100; 
                break;
             default: //defaultはelseの意味
                break;

        }


       //Debug.Log("playerのHPは"+ playerHP);
    } 
	
	// Update is called once per frame
	void Update () {
		
	}
}
