using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyEnemy : Enemy
{
    private Rigidbody2D rig;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rig.velocity = Vector2.left * speed;
    }
}
