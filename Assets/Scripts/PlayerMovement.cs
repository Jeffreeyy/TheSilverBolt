using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(PlayerCollisionChecker))]
public class PlayerMovement : MonoBehaviour 
{
    private float _movementSpeed = 1;
    public float MovementSpeed
    {
        get
        {
            return _movementSpeed;
        }
        set
        {
            _movementSpeed = value;
        }
    }
    [SerializeField]private bool _duck = false;
    public bool Duck
    {
        get
        {
            return _duck;
        }
        set
        {
            _duck = value;
        }
    }
    private Rigidbody _rb;
    private PlayerCollisionChecker _colChecker;
    [SerializeField]private float _jumpSpeed;

    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _colChecker = GetComponent<PlayerCollisionChecker>();
    }

    public void JumpUp()
    {
        if (_colChecker.CanJump)
        {
            _rb.velocity = new Vector3(0, _jumpSpeed, 0);
        }
    }

    public void MoveLeft()
    {
        if(_colChecker.CanMoveLeft())
        {
            transform.Translate(Vector2.left * _movementSpeed * Time.deltaTime);
        }
    }

    public void MoveRight()
    {
        if (_colChecker.CanMoveRight())
        {
            transform.Translate(Vector2.right * _movementSpeed * Time.deltaTime);
        }
    }
}