using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player_HP_script : MonoBehaviour
{
    public Slider _slider;
    public int playerHP;
    // Start is called before the first frame update
    void Start()
    {
        playerHP = 100;
    }

    // Update is called once per frame
    void Update()
    {
        _slider.value = playerHP;
        if (playerHP == 0)
        {
            Debug.Log("gameover");
        }
    }
    private void  OnCollisionEnter(Collision collision)
    {
     
    }
}
