using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public List<GameObject> enemiesList = new List<GameObject>();

    private float timeCount;
    public float spawnTimeMin;
    public float spawnTimeMax;

    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        timeCount += Time.deltaTime;

        if (timeCount >= Random.Range(spawnTimeMin, spawnTimeMax))
        {
            SpawnEnemy();
            timeCount = 0f;
        }
    }

    void SpawnEnemy()
    {
        Instantiate(enemiesList[Random.Range(0, enemiesList.Count)], transform.position + new Vector3(0f, Random.Range(-1f, 3f), 0f), transform.rotation);
    }
}
