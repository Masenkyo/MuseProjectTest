using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    Text HP;
    GameObject Player;
    int hp = 10;
    int maxHp = 10;
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (hp > maxHp) hp = maxHp;
        HP.text = hp.ToString();
    }
}
