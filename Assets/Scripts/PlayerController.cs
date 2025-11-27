using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float X, Y;
    public float Speed;
    public Joystick joystick;
    private Rigidbody2D rb;
    private Vector2 teleport1Pos, teleport2Pos;
    private float distance1, distance2;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        teleport1Pos = GameObject.Find("teleport1").transform.position;
        teleport2Pos = GameObject.Find("teleport2").transform.position;
    }
    
    void Update()
    {
        distance1 = Vector2.Distance(transform.position, teleport1Pos);
        distance2 = Vector2.Distance(transform.position, teleport2Pos);
        Debug.Log("1 - " + distance1);
        Debug.Log("2 - " + distance2);
        Vector2 needPos1 = new Vector2(teleport1Pos.x + 2,  teleport1Pos.y + 2);
        Vector2 needPos2 = new Vector2(teleport2Pos.x + 2,  teleport2Pos.y + 2);
        if (distance1 <= 1)
        {
            transform.position = needPos2;
        }

        if (distance2 <= 1)
        {
            transform.position = needPos1;
        }
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
