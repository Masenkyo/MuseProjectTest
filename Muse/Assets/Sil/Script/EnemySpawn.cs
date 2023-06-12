using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject player;
    public Spawns Spawn;
    [SerializeField] int wave = 0;
    public List<Spawns> SpawnList;

    void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < 5)
        {
            Spawn = SpawnList[wave];
            StartCoroutine(wavestart());
            wave++;
        }
        if (wave > SpawnList.Count) StopAllCoroutines();
    }
    IEnumerator wavestart()
    {
        for (int i = 0; i < Spawn.Enemies.Length; i++)
        {
            for (int j = 0; j < Spawn.Amounts[i]; j++)
            {
                Instantiate(Spawn.Enemies[i], this.transform.position, Quaternion.identity);
                yield return new WaitForSeconds(3f);
            }
        }
    }
}
