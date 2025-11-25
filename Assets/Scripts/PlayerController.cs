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
        rb.AddForce(new Vector2(X, Y) * Speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Meteor"))
        {
            gameObject.SetActive(false);
            GameController.Lose = true;
        }
    }
}
