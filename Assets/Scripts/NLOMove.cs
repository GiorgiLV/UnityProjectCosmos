using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class NloMove : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float speed;
    private Vector3 newPos;
    private bool isMoving;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    void Update()
    {
        if (Vector3.Distance(player.position, transform.position) < 50)
        {
            isMoving = false;
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
        else
        {
            if (!isMoving)
            {
                newPos.x = transform.position.x + Random.Range(-50, 50);
                newPos.y = transform.position.y + Random.Range(-50, 50);
                isMoving = !isMoving;
            }

            transform.position = Vector3.MoveTowards(transform.position, newPos, speed * Time.deltaTime);

            if (Vector2.Distance(transform.position, newPos) <= 1)
            {
                isMoving = !isMoving;
            }
        }
    }
}
