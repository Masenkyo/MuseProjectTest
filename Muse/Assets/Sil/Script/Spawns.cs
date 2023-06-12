using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewSpawn", menuName = "Muse/Spawn")]
public class Spawns : ScriptableObject
{
    public GameObject[] Enemies;
    public int[] Amounts;
}
