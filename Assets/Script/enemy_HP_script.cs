using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemy_HP_script : MonoBehaviour
{
    public Slider _slider;
    public int EnemyHP;
    // Start is called before the first frame update
    void Start()
    {
        EnemyHP = 100;
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
