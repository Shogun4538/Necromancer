using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shadow1_UI : MonoBehaviour
{
    GameObject Player;
    PlayerController script;
    public Text TextFrame;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("SD_unitychan_humanoid");
        script = Player.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        int Shadow1 = script.score;
        TextFrame.text = string.Format("Shadow1- {0:0}", Shadow1);
        Shadow1++;
    }
}
