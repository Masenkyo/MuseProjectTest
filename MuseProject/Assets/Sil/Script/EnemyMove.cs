using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject rangedEnemy;
    public GameObject enemy;
    public GameObject player;
    float speed = 3;
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Enemy();
        RangedEnemy();
    }
    void Enemy()
    {
        if (Vector3.Distance(transform.position, player.transform.position) > 1.5f)
            enemy.transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }
    void RangedEnemy()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < 5)
            rangedEnemy.transform.position = Vector3.MoveTowards(transform.position, player.transform.position, -speed * Time.deltaTime / 2);
        if (Vector3.Distance(transform.position, player.transform.position) > 5)
            rangedEnemy.transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime / 2);
    }
}
