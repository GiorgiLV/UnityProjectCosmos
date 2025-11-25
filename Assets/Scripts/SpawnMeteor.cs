using UnityEngine;

public class SpawnMeteor : MonoBehaviour
{
    [SerializeField] private GameObject Meteor;
    [SerializeField] private int numOfMeteors;

    void Start()
    {
        for (int i = 0; i < numOfMeteors; i++)
        {
            GameObject meteorClone = Instantiate(Meteor, new Vector2(Random.Range(-9000, 9000), Random.Range(-9000, 9000)), Quaternion.identity);
            meteorClone.name = $"MeteorClone{i}";
            meteorClone.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-50, 50), Random.Range(-30, 30)), ForceMode2D.Impulse);
        }
    }
}
