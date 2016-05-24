using UnityEngine;
using System.Collections;

[RequireComponent(typeof(PlayerMovement))]
public class PlayerInput : MonoBehaviour 
{
    private PlayerMovement _movement;

    void Awake()
    {
        _movement = GetComponent<PlayerMovement>();
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
