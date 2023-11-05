using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject[] coins;
    public List<Transform> spawnPoints;

    void Start()
    {
        spawnPoints = new List<Transform>(spawnPoints);
        SpawnCoins();
    }

    void SpawnCoins()
    {
        for (int i = 0; i < coins.Length; i++)
        {
            var spawn = Random.Range(0, spawnPoints.Count);
            Instantiate(coins[i], spawnPoints[spawn].transform.position, Quaternion.identity);
            spawnPoints.RemoveAt(spawn);
        }
    }
}
