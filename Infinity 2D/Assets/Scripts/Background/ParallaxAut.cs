using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxAut : MonoBehaviour
{
    public Transform pointInit;
    public Transform pointFinish;
    public float speedParallax;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position = new Vector3(transform.position.x - speedParallax
            ,transform.position.y, transform.position.z);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PointFinish"))
        {
            transform.position = pointInit.position;
        }
    }
}
