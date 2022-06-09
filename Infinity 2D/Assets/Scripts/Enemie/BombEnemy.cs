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

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("CamFinish"))
        {
            Destroy(gameObject);
        }

        if (collision.CompareTag("Bullet"))
        {
            collision.GetComponent<Projectile>().OnHit();
            ApplyDamage(collision.GetComponent<Projectile>().damage);
        }
    }
}
