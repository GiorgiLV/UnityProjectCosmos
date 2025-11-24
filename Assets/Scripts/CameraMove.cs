using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject target;
    public float speed;
    private Vector3 targetPos;
    void Start()
    {
        targetPos = target.transform.position;
        targetPos.z = -10;
    }
    
    void Update()
    {
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, targetPos, speed * Time.deltaTime);
    }
}
