using UnityEngine;
using System.Collections;

[RequireComponent(typeof(PlayerMovement))]
public class PlayerAbilities : MonoBehaviour {

    private PlayerMovement _movement;
    private PlayerPower _playerPower;
    [SerializeField]private float _normalMoveSpeed;
    [SerializeField]private float _enhancedMoveSpeed;
    private ParticleSystem[] _particleSystem;

    void Start()
    {
        _particleSystem = GetComponentsInChildren<ParticleSystem>();
        _movement = GetComponent<PlayerMovement>();
        _playerPower = GetComponent<PlayerPower>();
        _normalMoveSpeed = _movement.MovementSpeed;
    }

    private void EmitParticles(bool activate)
    {
        for (int i = 0; i < _particleSystem.Length; i++)
        {
            var em = _particleSystem[i].emission;
            em.enabled = activate;
        }
    }

    public void ActivateSpeedBuff()
    {
        if (_playerPower.Power > 0 && !_playerPower.IsUsingPower)
        {
            _playerPower.IsUsingPower = true;
            EmitParticles(true);
            _movement.MovementSpeed = _enhancedMoveSpeed;
            StartCoroutine(_playerPower.PowerDrain());
            
        }
    }

    public void DeactivateSpeedBuff()
    {
        _playerPower.IsUsingPower = false;
        EmitParticles(false);
        _movement.MovementSpeed = _normalMoveSpeed;
    }

    
}