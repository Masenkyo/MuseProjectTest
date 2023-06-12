using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    Text HP;
    GameObject Player;
    public int hp = 3;
    public int maxHp = 3;
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (hp > maxHp) hp = maxHp;
        //HP.text = hp.ToString();
    }
}
