using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PowerUps/Dash")]
public class PowerUpDash : PowerUpEffect
{
    public int DashAmount;
    public float VignetteValue;

    public override void Apply(GameObject target)
    {
        target.GetComponent<Movement>().dashCap += DashAmount;
        target.GetComponent<PlayerVignette>().VignetteMaxValue += VignetteValue;
    }
}
