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
	    if (Input.GetKey(KeyCode.UpArrow))
        {

        }
        //DOWN
        if (Input.GetKey(KeyCode.DownArrow))
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
        if (Input.GetKey(KeyCode.Z))
        {

        }
        //ABILITY 2
        if (Input.GetKey(KeyCode.X))
        {

        }

	}
}
