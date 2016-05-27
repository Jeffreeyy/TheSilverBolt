using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PowerBar : MonoBehaviour 
{
    [SerializeField]private Image _powerBar;
    private float _powerOffset;
    private PlayerPower _playerPower;
    // use this for initialization
    void Start()
    {
        _playerPower = GetComponent<PlayerPower>();
        _powerOffset = _playerPower.Power;
    }

    // Update is called once per frame 
    void Update()
    {
        _powerBar.fillAmount = _playerPower.Power / _powerOffset;
    }
}