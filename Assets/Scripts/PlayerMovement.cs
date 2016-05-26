using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
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
    private CharacterController _cc;
    [SerializeField]private float _jumpSpeed;
    [SerializeField]private float _gravity;
    private Vector2 _jumpDirection;

    void Awake()
    {
        _cc = GetComponent<CharacterController>();
    }

    void FixedUpdate()
    {
        Move();
    }

    public void JumpUp()
    {
        if (_cc.isGrounded)
        {
            _jumpDirection.y = _jumpSpeed;
        }
    }

    public void DuckDown()
    {
        
    }

    public void MoveLeft()
    {
        _cc.Move(Vector2.left * _movementSpeed * Time.fixedDeltaTime);
        transform.eulerAngles = new Vector2(0, 180);
    }

    public void MoveRight()
    {
        _cc.Move(Vector2.right * _movementSpeed * Time.fixedDeltaTime);
        transform.eulerAngles = new Vector2(0, 0);
    }

    private void Move()
    {
        _jumpDirection.y -= _gravity * Time.fixedDeltaTime;
        _cc.Move(_jumpDirection * Time.fixedDeltaTime);
    }
}