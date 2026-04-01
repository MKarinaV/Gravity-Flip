using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject obstaclePrefab;

    void Start()
    {
        InvokeRepeating("SpawnObstacle", 1f, 2f);
    }

    void SpawnObstacle()
    {
        float randomY = Random.value > 0.5f ? -3f : 3f;

        Vector2 spawnPos = new Vector2(10f, randomY);

        Instantiate(obstaclePrefab, spawnPos, Quaternion.identity);
    }
}