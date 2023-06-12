using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    Text HP;
    GameObject Player;
<<<<<<< HEAD
    public int hp = 10;
    int maxHp = 10;
=======
    public int hp = 3;
    public int maxHp = 3;
>>>>>>> e47e83a0890c0bcef47bebf614cd2dac8543dc75
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
