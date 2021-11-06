using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContoller : MonoBehaviour
{
    public int death = 0;//敵が死んだ回数
    public int enemyHP = 3;//敵のHP
    public int enemyHP1 = 5;
    public GameObject GetShadow1;//魂とりおわった敵
    //public GameObject GetShadow2;//魂とりおわった敵1

    // Start is called before the first frame update
    void Start()
    {
}

    // Update is called once per frame
    void Update()
    {
        if (enemyHP == 0)
        {
            
            this.tag = "enemy_not";
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "player")//プレイヤーにあったたら
        {
            death = 2;
            death = 0;
            enemyHP -= 1;
            //enemyHP1 -= 1;
            Debug.Log("敵のHPは" + enemyHP);
            Debug.Log("Player collision");
        }
        if (collision.collider.tag == "player")//もしタグがプレイヤーだったら
        {
            if (enemyHP == 0)
            {
                Destroy(gameObject);//敵を消す
                Instantiate(GetShadow1, transform.position, transform.rotation);//getshadowをスポーンさせる
            }
            /*if (enemyHP1 == 0)
            {
                Destroy(gameObject);//敵を消す
                Instantiate(GetShadow2, transform.position, transform.rotation);//getshadowをスポーンさせる
            }*/
        }
    }
}
