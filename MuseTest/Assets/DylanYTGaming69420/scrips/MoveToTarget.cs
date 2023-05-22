using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTarget : MonoBehaviour
{
    public float speed;
    public Transform target;
    public float minDistance;

    void Update()
    {
        MoveToPlayer();
    }

    void MoveToPlayer()
    {
        if (Vector3.Distance(transform.position, target.transform.position) > minDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
        }
    }
}
