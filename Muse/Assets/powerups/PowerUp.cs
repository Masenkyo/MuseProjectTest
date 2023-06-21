using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public PowerUpEffect PowerUpEffect;
    bool once = true;
    public GameObject drunk;
    public GameObject cam;

    private void OnTriggerEnter(Collider collision)
    {
        Destroy(gameObject);
        PowerUpEffect.Apply(collision.gameObject);
        if (once == true)
        {
            Instantiate(drunk, new Vector3(9.5f, 15.5f, -16.25f), drunk.transform.rotation);
            once = false;
        }
    }
}
