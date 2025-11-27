using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private float _smooth;
    [SerializeField] private Transform _target;
    private Vector3 _diff;
    private Vector3 _camPos;

    private void Start()
    {
        _diff = transform.position - _target.position;
    }

    private void FixedUpdate()
    {
        CamFollowing();
    }

    private void CamFollowing()
    {
        _camPos = _target.position + _diff;
        transform.position = Vector3.Lerp(transform.position, _camPos, _smooth * Time.fixedDeltaTime);
    }
}