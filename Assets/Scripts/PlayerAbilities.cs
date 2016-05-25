using UnityEngine;
using System.Collections;

[RequireComponent(typeof(PlayerMovement))]
public class PlayerAbilities : MonoBehaviour {

    private PlayerMovement _movement;
    [SerializeField]private float _normalMoveSpeed;
    [SerializeField]private float _enhancedMoveSpeed;
    private ParticleSystem _particleSystem;

    void Start()
    {
        _particleSystem = GetComponentInChildren<ParticleSystem>();
        _movement = GetComponent<PlayerMovement>();
        _normalMoveSpeed = _movement.MovementSpeed;
    }

    public void ActivateSpeedBuff()
    {
        var em = _particleSystem.emission;
        _movement.MovementSpeed = _enhancedMoveSpeed;
        em.enabled = true;
    }

    public void DeactivateSpeedBuff()
    {
        var em = _particleSystem.emission;
        _movement.MovementSpeed = _normalMoveSpeed;
        em.enabled = false;
    }
}
