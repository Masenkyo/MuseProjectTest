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
        target.GetComponentInChildren<PlayerHP>().maxHp += HealthAmount;
        target.GetComponentInChildren<PlayerHP>().hp += HealthAmount;
        target.GetComponentInChildren<Movement>().moveSpeed += SpeedAmount;
    }
}
