﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    float speed = 3.0f;
    public int score = 0;
    public GameObject shadow1;//影
    public GameObject sword1;//剣１の当たり判定の棒
    public GameObject GetShadow1;//魂とりおわった敵
    public Text level_UI;//プレイヤーのレベルのUI
    public int level;//プレイヤーのレベル
    public int enemy;//プレイヤーが倒した敵の数
    public int enemyHP = 3;//敵のhp
    //public int enemy_death_count;//敵が死んだ数
    private Vector3 Player_pos; //プレイヤーのポジション
    private float x; //x方向のImputの値
    private float z; //z方向のInputの値
    private Rigidbody rigd;
    public GameObject Ken_Col;
    



    // Start is called before the first frame update
    void Start()
    {
        level = 0;
        score = 0;
        Debug.Log(score);
        Player_pos = GetComponent<Transform>().position; //最初の時点でのプレイヤーのポジションを取得
        rigd = GetComponent<Rigidbody>(); //プレイヤーのRigidbodyを取得
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("e"))
        {
            if (score >= 1)//スコアが
            {
                Instantiate(shadow1, new Vector3(this.transform.position.x, this.transform.rotation.y+3, this.transform.position.z),Quaternion.identity);
                score -= 1;
                Debug.Log(score);
            }
        }
        if (Input.GetMouseButtonDown(0))//マウスをクリックしたらsword_Actionを起こす
        {
            StartCoroutine("Sword_Action");
        }
        
        level_UI.text = string.Format("{0:0}", level);//プレイヤーのレベル
       
        if (score == 3)
        {
            level = +1;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.collider.tag == "Shadow1(1)")//自分よりレベルが低かったらshadowの魂をとtrないようにする
        {
            if (level >= 1)
            {
                score += 1;
                Debug.Log(score);
            }
        }
        if (collision.collider.tag == "Shadow1")
        {
            score += 1;
            Debug.Log(score);
        }
    }
    IEnumerator Sword_Action()//swoed_Actionを起こされた時ken_colのSetActiveをonにする
    {
        Ken_Col.SetActive(true);
        yield return new WaitForSeconds(0.000000001f);
        Ken_Col.SetActive(false);
        yield return null;
    }
}
