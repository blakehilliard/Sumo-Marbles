using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject powerupPrefab;
    private float horizontalSpawnRange = 9.0f;
    public int enemyCount;
    private int wave = 1;

    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave(wave);
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        if (enemyCount == 0)
        {
            wave++;
            SpawnEnemyWave(wave);
        }
    }

    private void SpawnEnemyWave(int num)
    {
        for (int i = 0; i < num; i++)
        {
            SpawnEnemy();
        }
        SpawnPowerup();
    }

    private void SpawnEnemy()
    {
        float x = Random.Range(-horizontalSpawnRange, horizontalSpawnRange);
        float y = Random.Range(0, 2) == 0 ? 0.15f : 2.0f; // on ground or drop
        float z = Random.Range(-horizontalSpawnRange, horizontalSpawnRange);
        Instantiate(enemyPrefab, new Vector3(x, y, z), enemyPrefab.transform.rotation);
    }

    private void SpawnPowerup()
    {
        float x = Random.Range(-horizontalSpawnRange, horizontalSpawnRange);
        float y = 0.15f;
        float z = Random.Range(-horizontalSpawnRange, horizontalSpawnRange);
        Instantiate(powerupPrefab, new Vector3(x, y, z), powerupPrefab.transform.rotation);
    }
}
