using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject rangedEnemy;
    public GameObject enemy;
    private GameObject player;
    float enemyTime;
    float rEnemyTime;
    bool enemyReady = false;
    bool rEnemyReady = false;
    float speed = 2;
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyReady == false) enemyTime += Time.deltaTime;
        if (enemyTime >= 1) enemyReady = true;
        if (rEnemyReady == false) rEnemyTime += Time.deltaTime;
        if (rEnemyTime >= 5) rEnemyReady = true;
        Enemy();
        RangedEnemy();
    }
    void Enemy()
    {
        if (Vector3.Distance(transform.position, player.transform.position) > 1.5f)
            enemy.transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, player.transform.position) < 2f && enemyReady == true)
        {
            player.GetComponent<PlayerHP>().hp -= 1;
            enemyReady = false;
            enemyTime = 0;
        }

    }
    void RangedEnemy()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < 4)
            rangedEnemy.transform.position = Vector3.MoveTowards(transform.position, player.transform.position, -speed * Time.deltaTime / 2);
        if (Vector3.Distance(transform.position, player.transform.position) > 4)
            rangedEnemy.transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime / 2);
        if (Vector3.Distance(transform.position, player.transform.position) > 3.5f && rEnemyReady == true)
        {
            player.GetComponent<PlayerHP>().hp -= 2;
            rEnemyReady = false;
            rEnemyTime = 0;
        }
    }
}
