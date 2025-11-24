using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject target;
    public float speed;
    private Vector3 targetPos;
    
    void Update()
    {
        targetPos = target.transform.position;
        targetPos.z = -10;
        gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, targetPos, speed * Time.deltaTime);
    }
}
