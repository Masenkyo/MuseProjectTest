using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class Attack : MonoBehaviour
{
    public float time = 0.4f;
    public bool ready = false;
    public Animator animator;

    public List<EnemyHP> enemies = new List<EnemyHP>();

    void Update()
    {
        if (time <= 0.5f)
            time += Time.deltaTime;

        if (enemies.Count > 0 && Input.GetButtonDown("Fire1") && ready)
        {
            foreach (EnemyHP enemy in enemies)
            {
                enemy.HP -= 1;
            }

            ready = false;
            time = 0;
        }

        if (Input.GetButtonDown("Fire1") && ready)
        {
            animator.SetBool("Attacking", true);
            ready = false;
            time = 0;
        }
        else
        {
            animator.SetBool("Attacking", false);
        }

        if (time >= 0.5f)
        {
            ready = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        EnemyHP enemyHP = other.GetComponent<EnemyHP>();
        if (enemyHP != null)
        {
            enemies.Add(enemyHP);
        }
    }

    void OnTriggerExit(Collider other)
    {
        EnemyHP enemyHP = other.GetComponent<EnemyHP>();
        if (enemyHP != null)
        {
            enemies.Remove(enemyHP);
        }
    }
}
