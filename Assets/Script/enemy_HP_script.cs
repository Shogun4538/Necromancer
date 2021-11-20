using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemy_HP_script : MonoBehaviour
{
    Slider _slider;//スライダー
    public int EnemyHP;//敵の
    GameObject Player;
    PlayerController script;
    // Start is called before the first frame update
    void Start()
    {
        EnemyHP = 3;
        _slider = GetComponent<Slider>();

        float maxHp = 3f;
        float nowHp = 0f;

        //スライダーの最大値の設定
        _slider.maxValue = maxHp;

        //スライダーの現在値の設定
        _slider.value = nowHp;
    }

    // Update is called once per frame
    void Update()
    {
        _slider.value = EnemyHP;
    }
    private void OnCollisionEnter(Collision collision)
    {

    }
}
