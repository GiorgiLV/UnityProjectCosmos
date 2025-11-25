using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
   [SerializeField] private Joystick _joystick;
   [SerializeField] private float _xAxis, _yAxis;
   [SerializeField] private  float _speed;
   private Rigidbody2D _rb;
   private bool _isNitroOn;

   void Start()
   {
      _rb =  GetComponent<Rigidbody2D>();
   }
   void Update()
   {
      _xAxis = _joystick.Horizontal;
      _yAxis = _joystick.Vertical;
   }

   private void FixedUpdate()
   {
      _rb.AddForce(new Vector2(_xAxis * _speed, _yAxis * _speed));
   }

    public void OnButtonDown()
    {
        _isNitroOn = true;
        _speed *= 2;
        Debug.Log(_speed);
    }

    public void OnButtonUp()
    {
        _isNitroOn = true;
        _speed /= 2;
        Debug.Log(_speed);

    }
}
