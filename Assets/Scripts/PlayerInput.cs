using UnityEngine;
using System.Collections;

[RequireComponent(typeof(PlayerAbilities))]
[RequireComponent(typeof(PlayerMovement))]
public class PlayerInput : MonoBehaviour 
{
    private PlayerMovement _movement;
    private PlayerAbilities _abilities;

    void Awake()
    {
        _movement = GetComponent<PlayerMovement>();
        _abilities = GetComponent<PlayerAbilities>();
    }

	void FixedUpdate () 
    {
        //UP
	    if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _movement.JumpUp();
        }
        //DOWN
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {

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
        if (Input.GetKeyDown(KeyCode.Z))
        {
            
        } 
        //ABILITY 2
        if (Input.GetKeyDown(KeyCode.X))
        {

        }
	}
}
