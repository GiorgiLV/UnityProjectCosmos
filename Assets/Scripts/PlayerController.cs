using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float X, Y;
    public float Speed;
    public Joystick joystick;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        X = joystick.Horizontal;
        Y = joystick.Vertical;
    }

    void FixedUpdate()
    {
        Vector2 movement = new Vector2(X, Y);
        rb.linearVelocity = movement * Speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Meteor") || collision.gameObject.CompareTag("NLO"))
        {
            gameObject.SetActive(false);
            joystick.gameObject.SetActive(false);
            GameController.Lose = true;
        }

        if (collision.gameObject.CompareTag("Station"))
        {
            joystick.gameObject.SetActive(false);
            GameController.Win = true;
        }
    }
}
