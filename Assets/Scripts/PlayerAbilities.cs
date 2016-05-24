using UnityEngine;
using System.Collections;

[RequireComponent(typeof(PlayerMovement))]
public class PlayerAbilities : MonoBehaviour {

    private PlayerMovement _movement;
    [SerializeField]private float enhancedMoveSpeed;

    void Start()
    {
        _movement = GetComponent<PlayerMovement>();
    }

    void Update()
    {

    }

    public void ActivateSpeedBuff()
    {
        _movement._movementSpeed = enhancedMoveSpeed;
    }

    public void DeactivateSpeedBuff()
    {

    }
}
