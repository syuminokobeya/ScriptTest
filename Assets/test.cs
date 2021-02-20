using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Boss
{
        private int hp = 100;          // 体力
        private int power = 25; // 攻撃力
    public int mp = 53;
    public void Magic()
    {
        if (mp >= 5)
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした.残りMPは"+mp);

        }
        else{
            Debug.Log("MPが足りないため魔法が使えない");
            }
    }

        // 攻撃用の関数
        public void Attack()
        {
                Debug.Log( this.power + "のダメージを与えた" );
        }

        // 防御用の関数
        public  void Defence(int damage)
        {
                Debug.Log( damage+"のダメージを受けた" );
                // 残りhpを減らす
                this.hp -= damage;
        }

}


public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Boss lastboss = new Boss();
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
        //コンソールにHello,Worldと表示
        Debug.Log("Hello,World");
        int[] array = { 20, 40, 60, 80, 100 }; //要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください
        for (int i = 0; i < 5; i++)//for文を使い、配列の各要素の値を順番に表示してください
        {
            Debug.Log(array[i]);
        }
        for (int a= 0; a <5; a++)//for文を使い、配列の各要素の値を逆順に表示してください
        {
            Debug.Log(array[4-a]);
        }


    }

    // Update is called once per frame
    void Update()
    {
        

    }
}