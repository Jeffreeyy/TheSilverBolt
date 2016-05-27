using UnityEngine;
using System.Collections;

public class PlayerPower : MonoBehaviour 
{
    private float _drainRate = .1f;
    private float _drainAmount = 1;
    private float _rechargeRate = .1f;
    private float _rechargeAmount = .2f;
    private float _maxPower;
    private float _power = 100;
    public float Power
    {
        get
        {
            return _power;
        }
        set
        {
            _power = value;
        }
    }

    private bool _isUsingPower = false;
    public bool IsUsingPower
    {
        get
        {
            return _isUsingPower;
        }
        set
        {
            _isUsingPower = value;
        }
    }
    private PlayerAbilities _playerAbilities;

    private bool _isRecharging = false;

    // use this for initialization
    void Start()
    {
        _playerAbilities = GetComponent<PlayerAbilities>();
        _maxPower = _power;
    }

    // Update is called once per frame 
    void Update()
    {
        Recharge();
    }

    private void Recharge()
    {
        if (!_isUsingPower && _power < _maxPower && !_isRecharging)
        {
            StartCoroutine(Recharging());
        }
        else if (_isUsingPower)
        {
            _isRecharging = false;
        }
    }

    public IEnumerator PowerDrain()
    {
        while (_isUsingPower)
        {
            yield return new WaitForSeconds(_drainRate);

            if (_power > 0)
            {
                _power -= _drainAmount;
            }
            else
                _playerAbilities.DeactivateSpeedBuff();
        }
    }

    IEnumerator Recharging()
    {
        _isRecharging = true;
        while (!_isUsingPower)
        {
            yield return new WaitForSeconds(_rechargeRate);
            _power += _rechargeAmount;
        }
    }
}