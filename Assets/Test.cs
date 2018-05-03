using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	void Start () {
        //Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        //攻撃用の関数を呼び出す
        lastboss.Attack();
        //防御用の関数を呼び出す
        lastboss.Defence(3);
        //魔法攻撃の関数を呼び出す
        lastboss.Magic(5);
        //魔法攻撃の関数を10回呼び出す
        for ( int mp = 0; mp < 10; mp++)
        {
            lastboss.Magic(5);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}

}
public class Boss
{
    private int hp = 100;          //体力
    private int power = 25;        //攻撃力
    private int mp = 53;            //MP

    //攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    //防御用の関数
    public void Defence(int damege)
    {
        Debug.Log(damege + "のダメージを受けた");
        //残りHPを減らす
        this.hp -= damege;
    }

    //mpを消費して魔法攻撃する関数
    public void Magic(int magicalattack)
    {
        if (mp <= magicalattack)
        {
            //魔法攻撃をしようとした際に mpが0以下になる場合、「MPが足りないため魔法が使えない。」と表示する
            Debug.Log("MPが足りないため魔法が使えない。");
        }
        else
        {
            //MPが0より多ければMPを消費して魔法攻撃をする
            this.mp -= magicalattack;
            Debug.Log("魔法攻撃をした。残りMPは" + mp);
        }
    }
}
