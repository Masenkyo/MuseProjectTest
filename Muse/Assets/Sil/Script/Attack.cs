using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class Attack : MonoBehaviour
{
    public List<GameObject> enemies = new List<GameObject>();
    void Update()
    {
        if (enemies.Count > 0 && Input.GetButtonDown("Fire1"))
        {
            foreach (GameObject enemy in enemies)
            {
                enemy.GetComponent<EnemyHP>().HP -= 1;
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        enemies.Add(other.gameObject);
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Enemy"))
        enemies.Remove(other.gameObject);
    }
}
