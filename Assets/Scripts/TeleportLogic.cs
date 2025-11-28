using System;
using UnityEngine;

public class TeleportLogic : MonoBehaviour
{
    [SerializeField] private GameObject player, teleport1, teleport2;
    private float distance1, distance2, timer = 5;
    
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            Debug.Log(Convert.ToInt32(timer));
        }
        else
        {
            timer = 0;
        }
        distance1 = Vector3.Distance(player.transform.position, teleport1.transform.position);
        distance2 = Vector3.Distance(player.transform.position, teleport2.transform.position);

        if (distance1 <= 10 && timer == 0)
        {
            player.transform.position = new Vector2(teleport2.transform.position.x, teleport2.transform.position.y + 20);
            timer = 5;
        }
        if (distance2 <= 10 && timer == 0)
        {
            player.transform.position = new Vector2(teleport1.transform.position.x, teleport1.transform.position.y + 20);
            timer = 5;
        }
    }
}
