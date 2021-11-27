using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemy_HP_script : MonoBehaviour
{
    public Slider _slider;//スライダー
    public int EnemyHP;//敵の
    GameObject Player;
    PlayerController script;
    // Start is called before the first frame update
    void Start()
    {
        EnemyHP = 3;

    }

    // Update is called once per frame
    void Update()
    {
        _slider.value = EnemyHP;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "sword")
        {
            EnemyHP -= 1;
            Debug.Log("aaaaa");
        }
    }
}
