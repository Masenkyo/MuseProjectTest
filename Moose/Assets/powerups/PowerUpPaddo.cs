using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PowerUps/Paddo")]
public class PowerUpPaddo : PowerUpEffect
{
    public int HealthAmount;
    public float SpeedAmount;


    public override void Apply(GameObject target)
    {
        target.GetComponent<PlayerHP>().maxHp += HealthAmount;
        target.GetComponent<Movement>().moveSpeed += SpeedAmount;
    }
}
