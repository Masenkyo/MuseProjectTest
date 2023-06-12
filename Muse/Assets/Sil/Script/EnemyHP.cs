using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public int HP = 10;
    void Update()
    {
        if (HP <= 0)
        {
            Destroy(gameObject);
        }
    }
}
