using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemiesPlatforms : MonoBehaviour
{
    public GameObject enemyPrefab;

    public List<Transform> points = new List<Transform>();

    private GameObject currentEnemy;

    // Start is called before the first frame update
    void Start()
    {
        CreateEnemy();
    }

    public void Spawn()
    {
        if (currentEnemy == null)
        {
            CreateEnemy();
        }
    }

    void CreateEnemy()
    {
        int pos = Random.Range(0, points.Count);
        GameObject e = Instantiate(enemyPrefab, points[pos].position, points[pos].rotation);
        currentEnemy = e;
    }
}
