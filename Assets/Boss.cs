using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    private int hp = 100;          // 体力
    private int mp =  53;          // マジックポイント
    private int power = 25; // 攻撃力

    // 魔法攻撃用の関数
    public void Magic()
    {
        Debug.Log( "魔法攻撃をした。残りMPは" + mp);
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のMPを消費した");
        // 残りmpを減らす
        mp -= damage;
    }

    // Update is called once per frame
    void Update()
    {

    }
}