using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnMeteor : MonoBehaviour
{
    [SerializeField] private GameObject meteor, nlo, meteors, nlos, player, station;
    [SerializeField] private int numOfMeteors, numOfNlo;
    [SerializeField] private Camera mainCam;
    void Start()
    {
        for (int i = 0; i < numOfMeteors; i++)
        {
            GameObject meteorClone = Instantiate(meteor, new Vector2(Random.Range(-5000, 5000), Random.Range(-5000, 5000)), Quaternion.identity);
            meteorClone.transform.SetParent(meteors.transform);
            meteorClone.name = $"MeteorClone{i+1}";
            meteorClone.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-50, 50), Random.Range(-30, 30)), ForceMode2D.Impulse);
        }

        for (int i = 0; i < numOfNlo; i++)
        {
            GameObject nloClone = Instantiate(nlo, new Vector2(Random.Range(-4000, 4000), Random.Range(-4000, 4000)), Quaternion.identity);
            nloClone.transform.SetParent(nlos.transform);
            nloClone.name = $"NLOClone{i+1}";
        }
        Vector3 playerSpawn = new Vector2(Random.Range(-3000, 3000), Random.Range(-3000, 3000));
        mainCam.transform.position = new Vector3(playerSpawn.x, playerSpawn.y, mainCam.transform.position.z);
        player.transform.position = playerSpawn;
        Vector3 stationSpawn = new Vector2(-playerSpawn.x,  -playerSpawn.y);
        GameObject stationClone = Instantiate(station, stationSpawn, Quaternion.identity);
    }
}
