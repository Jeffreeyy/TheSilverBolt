using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{
    [SerializeField]private float _movementSpeed;

    public void JumpUp()
    {
        
    }

    public void DuckDown()
    {
        
    }

    public void MoveLeft()
    {
        transform.Translate((Vector2.left) * _movementSpeed * Time.fixedDeltaTime);
    }

    public void MoveRight()
    {
        transform.Translate((Vector2.right) * _movementSpeed * Time.fixedDeltaTime);
    }


}
