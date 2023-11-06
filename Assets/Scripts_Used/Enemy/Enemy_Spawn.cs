using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawn : MonoBehaviour
{
    private GameObject Enemy;
    public GameObject Enemy_obj;
    [SerializeField] float EnemySpawnInterval;
    float EnemySpawnTimer = 0f;
    [SerializeField] Vector3 spawnposition;
    bool hasSpawned = false;
    [SerializeField] float No;

    void Start()
    {

    }

    void Update()
    {
        EnemySpawnTimer += Time.deltaTime;

        if (EnemySpawnTimer > EnemySpawnInterval && !hasSpawned)
        {
            StartCoroutine(SpawnEnemiesWithDelay());
            hasSpawned = true;
        }
    }

    IEnumerator SpawnEnemiesWithDelay()
    {
        for (int i = 0; i < No; i++)
        {
            Instantiate(Enemy_obj, spawnposition, Quaternion.identity);
            yield return new WaitForSeconds(0.5f); // Wait for 0.5 seconds before spawning the next enemy
        }
    }
}
