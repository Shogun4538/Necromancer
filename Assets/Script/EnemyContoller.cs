using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContoller : MonoBehaviour
{
    public int death = 0;//敵が死んだ回数
    public int enemyHP = 3;//敵のHP
    public GameObject GetShadow1;//魂とりおわった敵
    //public GameObject GetShadow2;//魂とりおわった敵1
    public int span = 3;//ダメージを与える間の時間
    private float currentTime = 0f;

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
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag== "sword")//剣にあったたら
        {
            enemyHP -= 1;
            Debug.Log("敵のHPは" + enemyHP);
            if (enemyHP <= 0)//もし敵のHPが0以下だった場合
            {
                Instantiate(GetShadow1, transform.position, transform.rotation);//getshadowをスポーンさせる
                Destroy(gameObject);//敵を消す
            }

        }
    }
    private void OnCollutionEnter(Collider collider)
    {
        currentTime += Time.deltaTime;
        if (currentTime > span)
        {
            enemyHP -= (Random.Range(1, 2));
            Debug.Log(enemyHP);
        }
    }
}
