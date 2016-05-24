using UnityEngine;
using System.Collections;

[RequireComponent(typeof(PlayerMovement))]
public class PlayerAbilities : MonoBehaviour {

    private PlayerMovement _movement;
    [SerializeField]private float _normalMoveSpeed;
    [SerializeField]private float _enhancedMoveSpeed;

    void Start()
    {
        _movement = GetComponent<PlayerMovement>();
        _normalMoveSpeed = _movement.MovementSpeed;
    }

    public void ActivateSpeedBuff()
    {
        _movement.MovementSpeed = _enhancedMoveSpeed;
    }

    public void DeactivateSpeedBuff()
    {
        _movement.MovementSpeed = _normalMoveSpeed;
    }
}
