using System.Collections;
using UnityEngine;

public class PlayerResources : MonoBehaviour
{
    private float _oxygen = 120.0f;
    private float _fuel = 12000f;
    private Vector3 _previousFramePosition;
    private int i;

    private void Start()
    {
        _previousFramePosition = gameObject.transform.position;
        StartCoroutine(OxygenSpending());
        StartCoroutine(FuelSpending());
    }

    private IEnumerator OxygenSpending()
    {
        while (i < 500)
        {
            _oxygen -= 1f;

            PlayerCore.Instance.IsPlayerAlive = _oxygen > 0f ? true : false;

            Debug.Log($"Player Alive? = {PlayerCore.Instance.IsPlayerAlive}");
            Debug.Log($"Oxygen: {_oxygen}");
            Debug.Log($"Fuel: {_fuel}");
            i++;
            yield return new WaitForSeconds(1f);
        }
    }

    private IEnumerator FuelSpending()
    {
        while (i < 500)
        {
            Vector2 diff = gameObject.transform.position - _previousFramePosition;
            float distance = diff.magnitude;

            if (PlayerCore.Instance.PlayerVector != Vector2.zero)
            {
                _fuel -= PlayerCore.Instance.IsNitroOn ? distance * 1.5f : distance;
            }

            _previousFramePosition = gameObject.transform.position;
            PlayerCore.Instance.IsMovementPossible = _fuel > 0 ? true : false;

            yield return new WaitForFixedUpdate();
        }
    }
}
