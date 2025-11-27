using UnityEngine;

/*
 * Common script to control Player's Scripts
 */

public class PlayerCore : MonoBehaviour
{
    public static PlayerCore Instance;

    [HideInInspector] public bool IsPlayerAlive = false;
    [HideInInspector] public bool IsMovementPossible = true;
    [HideInInspector] public bool IsPlayerMoving = false;
    [HideInInspector] public bool IsNitroOn = false;
    [HideInInspector] public Vector2 PlayerVector;

    private Rigidbody2D _playerRigidbody;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        Init();
    }

    private void Init()
    {
        _playerRigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (IsPlayerAlive == true)
        {
            MovePlayer();
        }
        else
        {
            DeadActions();
        }
    }

    private void MovePlayer()
    {
        if (IsMovementPossible)
        {
            _playerRigidbody.AddForce(PlayerVector);
        }
    }

    private void DeadActions()
    {

    }
}
