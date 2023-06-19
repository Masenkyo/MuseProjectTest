using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public int HP = 10;
    public GameObject drug;
    void Update()
    {
        if (HP <= 0)
        {
            Destroy(gameObject);
            int randomnumber = Random.Range(1, 5); 
            if(randomnumber == 1)
            {
                Instantiate(drug,gameObject.transform.position, Quaternion.identity);
            }
        }
    }
}
