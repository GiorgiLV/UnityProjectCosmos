using UnityEngine;

/*
 * Script for player's movement
 */

public class PlayerController : MonoBehaviour
{
    private float _x, _y;
    private float _speed = 2f;
    private float _nitroMultiplier = 2f;
    private Joystick _joystick;

    private void Start()
    {
        _joystick = GameObject.Find("Joystick").GetComponent<Joystick>();
    }

    void Update()
    {
        _x = _joystick.Horizontal;
        _y = _joystick.Vertical;

        NitroOnKeyForPCTests();
    }

    void FixedUpdate()
    {
        PlayerCore.Instance.PlayerVector = new Vector2(_x, _y) * _speed;
    }

    public void NitroButtonDown()               //Actions for pressed nitro speed button
    {
        _speed *= _nitroMultiplier;
        PlayerCore.Instance.IsNitroOn = true;
        Debug.Log($"Current Speed: {_speed}");
    }

    public void NitroButtonUp()                 //Actions for pressed nitro speed button
    {
        _speed /= _nitroMultiplier;
        PlayerCore.Instance.IsNitroOn = false;
        Debug.Log($"Current Speed: {_speed}");
    }

    private void NitroOnKeyForPCTests()             //Recieve keys from keyboard for Nitro(jesut developement feature, this will be deleted in a reales for android)
    {
        if (Input.GetKeyDown(KeyCode.LeftShift)) NitroButtonDown();
        if (Input.GetKeyUp(KeyCode.LeftShift)) NitroButtonUp();
    }
}
