using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomber : Enemy
{
    public GameObject expPrefab;
    public float speed;

    private Player player;
    private bool isCollider;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, player.gameObject.transform.position)
            < 5)
        {
            isCollider = true;
            GetComponent<Animator>().SetBool("run", true);
        }

        if (isCollider)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
    }

    public void OnHit()
    {
        GameObject e = Instantiate(expPrefab, transform.position, transform.rotation);
        Destroy(e, 1f);
        Destroy(gameObject);
    }

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            OnHit();
            player.OnHit(damage);
            Destroy(gameObject);
        }

        if (collision.CompareTag("Bullet"))
        {
            collision.GetComponent<Projectile>().OnHit();
            ApplyDamage(collision.GetComponent<Projectile>().damage);
        }

        if (collision.CompareTag("CamFinish"))
        {
            Destroy(gameObject);
        }
    }
}
