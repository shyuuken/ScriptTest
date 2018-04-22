using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{

    void Start()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 魔法攻撃用の関数を呼び出す
        lastboss.Magic();
        // 魔法防御用の関数を呼び出す
        lastboss.Defence(5);
    }

    // Update is called once per frame
    void Update()
    {

    }
}