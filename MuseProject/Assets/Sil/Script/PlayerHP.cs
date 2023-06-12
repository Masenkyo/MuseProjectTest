using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    Text HP;
    GameObject Player;
    public int hp = 10;
    public int maxHp = 10;
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (hp > maxHp) hp = maxHp;
    }
}
