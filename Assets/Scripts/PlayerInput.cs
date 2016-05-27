using UnityEngine;
using System.Collections;

[RequireComponent(typeof(PlayerMovement))]
public class PlayerInput : MonoBehaviour 
{
    private PlayerMovement _movement;
    private PlayerAbilities _abilities;
    private PlayerPower _playerPower;

    void Awake()
    {
        _movement = GetComponent<PlayerMovement>();
        _abilities = GetComponent<PlayerAbilities>();
        _playerPower = GetComponent<PlayerPower>();
    }

	void Update () 
    {
        //UP
	    if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _movement.JumpUp();
        }
        //DOWN
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            _movement.Duck = true;
        }
        //LEFT
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _movement.MoveLeft();
        }
        //RIGHT
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _movement.MoveRight();
        }
        //ABILITY 1
        if (Input.GetKey(KeyCode.Z))
        {
            _abilities.ActivateSpeedBuff();
        }
        else
            _abilities.DeactivateSpeedBuff();
        //ABILITY 2
        if (Input.GetKeyDown(KeyCode.X))
        {
            _abilities.Punch();
        }

        if(!Input.anyKey && !Input.anyKeyDown)
        {
            _playerPower.IsStandingStill = true;
        }
        else
        {
            _playerPower.IsStandingStill = false;
        }
	}
}
