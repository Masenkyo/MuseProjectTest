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
            Instantiate(drunk, cam.transform.position - new Vector3(0, 6, -3), drunk.transform.rotation);
            once = false;
        }
    }
}
