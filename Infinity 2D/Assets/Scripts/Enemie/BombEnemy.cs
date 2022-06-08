using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombEnemy : Enemy
{

    public GameObject bombPrefab;
    public Transform firePoint;

    public float throwTime;
    private float throwCount;

    // Update is called once per frame
    void Update()
    {
        throwCount += Time.deltaTime;

        if (throwCount >= throwTime)
        {
            Instantiate(bombPrefab, firePoint.position, firePoint.rotation);
            throwCount = 0f;
        }
    }
}
