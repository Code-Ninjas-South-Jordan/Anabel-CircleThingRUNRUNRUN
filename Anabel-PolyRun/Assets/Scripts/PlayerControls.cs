using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Default Jumping Power")]
    public float jumpPower = 6f;
    [Header("Boolean onGround")]
    public bool onGround = false;
    float posX = 0.0f;
    Rigidbody2D rb;
    void Start()
    {
        rb = transform.GetComponent<Rigidbody2D>();
        posX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Space) && onGround)
        {
            rb.AddForce(Vector3.up * (jumpPower * rb.mass * rb.gravityScale * 20.0f));
        }
        /*if(transform.position.x < posX)
        {
            GameOver();
        }*/
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Ground")
        {
            onGround = true;
        }
        /*if(collision.collider.tag == "Enemy")
        {
            GameOver();
        }*/
    }
    void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.collider.tag == "Ground")
        {
            onGround = true;
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.collider.tag == "Ground")
        {
            onGround = false;
        }
    }
    /*void GameOver()
    {
        GameObject.Find("GameController").GetComponent<GameController>().GameOver();
    }*/
    /*void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Coin")
        {
            GameObject.Find("GameController").GetComponent<GameController>().IncrementScore();
            Destroy(collision.gameObject);
        }
    }*/
}
