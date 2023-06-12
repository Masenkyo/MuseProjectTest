using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public PowerUpEffect PowerUpEffect;

    private void OnTriggerEnter(Collider collision)
    {
        Destroy(gameObject);
        PowerUpEffect.Apply(collision.gameObject);
    }
}
