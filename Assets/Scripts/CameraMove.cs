using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject target;
    public float speed;
    private Vector2 targetPos;
    
    void Update()
    {
        targetPos = target.transform.position;
        gameObject.transform.position = Vector3.Lerp(new Vector3(targetPos.x, targetPos.y, -50), targetPos, speed * Time.deltaTime);
    }
}
