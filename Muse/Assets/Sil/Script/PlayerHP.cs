using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    Text HP;
    GameObject Player;
    public float hp = 100;
    public float maxHp = 100;
    public Slider hpSlider;
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        CalculateHealth();
        if (hp > maxHp) hp = maxHp;
        hpSlider.value = CalculateHealth();
        ded();
    }
    public float CalculateHealth()
    {
        return hp / maxHp;
    }
    void ded()
    {
        if(hp < 0)
        {
            SceneManager.LoadScene("Died");
        }
    }
}
