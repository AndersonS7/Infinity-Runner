using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public float health;
    public float totalHealth;

    private bool isJumping;

    //public GameObject soundShoot;
    public Image healthImg;
    public Animator anim;
    private Rigidbody2D rig;
    public GameObject bulletPrefab;
    public Transform firePoint;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rig.velocity = new Vector2(speed, rig.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {
        ControlHealthUI();

        if (Input.GetKeyDown(KeyCode.E))
        {
            OnShoot();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnJump();
        }
    }

    public void OnShoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

    public void OnJump()
    {
        if (!isJumping)
        {
            rig.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            anim.SetBool("jumping", true);
            isJumping = true;
        }
    }

    public void OnHit(int dmg)
    {
        health -= dmg;

        if (health <= 0)
        {
            GameController.instance.ShowGameOver();
        }
    }

    public void ControlHealthUI()
    {
        healthImg.fillAmount = health / totalHealth;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            anim.SetBool("jumping", false);
            isJumping = false;
        }
    }
}
