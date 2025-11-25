using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject target;
    public float speed;
    private Vector3 targetPos;
    
    void Update()
    {
        targetPos = target.transform.position;
        gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, new Vector3(targetPos.x, targetPos.y, gameObject.transform.position.z), speed * Time.deltaTime);
    }
}
