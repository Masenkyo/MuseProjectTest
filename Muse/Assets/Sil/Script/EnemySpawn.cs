using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject player;
    public Spawns Spawn;
    [SerializeField] int wave = 0;
    public List<Spawns> SpawnList;
    int randomnumber = 0;

    void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < 10)
        {
            Spawn = SpawnList[wave];
            StartCoroutine(wavestart());
            wave++;
        }
        if (wave > SpawnList.Count) wave = 0;
        randomnumber = Random.Range(-3, 3);
    }
    IEnumerator wavestart()
    {
        for (int i = 0; i < Spawn.Enemies.Length; i++)
        {
            for (int j = 0; j < Spawn.Amounts[i]; j++)
            {
                Instantiate(Spawn.Enemies[i], transform.position += new Vector3(randomnumber, 0, randomnumber), Quaternion.identity);
                yield return new WaitForSeconds(4f);
            }
        }
    }
}
