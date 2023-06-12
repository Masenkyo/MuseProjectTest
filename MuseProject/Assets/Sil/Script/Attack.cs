using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class Attack : MonoBehaviour
{
    public List<GameObject> enemies = new List<GameObject>();
    public float time = 0.4f;
    public bool ready = false;
    void Update()
    {
        if (time <= 0.5f) time += Time.deltaTime;
        if (enemies.Count > 0 && Input.GetButtonDown("Fire1") && ready == true)
        {
            foreach (GameObject enemy in enemies)
            {
                enemy.GetComponent<EnemyHP>().HP -= 1;
            }
            ready = false;
            time = 0;
        }
        
        if (time >= 0.5f)
        {
            ready = true;
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
