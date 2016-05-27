using UnityEngine;
using System.Collections;

public class PlayerCollisionChecker : MonoBehaviour 
{
    private PlayerMovement _movement;
    [SerializeField]private bool _canJump = false;
    public bool CanJump
    {
        get
        {
            return _canJump;
        }
    }
    [SerializeField]private bool _canMoveRight = false;
    [SerializeField]private bool _canMoveLeft = false;

    [SerializeField]private float _obstacleRaycastRange;
    [SerializeField]private float _groundRaycastRange;

    void Awake()
    {
        _movement = GetComponent<PlayerMovement>();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ground" || col.gameObject.tag == "Platform")
        {
            _canJump = true;
        }
        if (col.gameObject.tag == "Platform" && _movement.Duck == true)
        {
            StartCoroutine(DisableGroundCollision(col, 0.5f));
        }
    }

    void OnCollisionStay(Collision col)
    {
        if (col.gameObject.tag == "Ground" || col.gameObject.tag == "Platform")
        {
            _canJump = true;
        }
        if (col.gameObject.tag == "Platform" && _movement.Duck == true)
        {
            StartCoroutine(DisableGroundCollision(col, 0.2f));
        }
    }

    void OnCollisionExit()
    {
        _canJump = false;
    }

    public bool CanMoveRight()
    {
        Vector3 rayOrigin = transform.position;

        Ray ray = new Ray();
        ray.origin = rayOrigin;
        ray.direction = Vector3.right;

        if (Physics.Raycast(ray, _obstacleRaycastRange, 1 << 9))
        {
            _canMoveRight = false;
        }
        else
        {
            _canMoveRight = true;
        }
        return _canMoveRight;
    }
    public bool CanMoveLeft()
    {
        Vector3 rayOrigin = transform.position;

        Ray ray = new Ray();
        ray.origin = rayOrigin;
        ray.direction = Vector3.left;

        if (Physics.Raycast(ray, _obstacleRaycastRange, 1 << 9))
        {
            _canMoveLeft = false;
        }
        else
        {
            _canMoveLeft = true;
        }
        return _canMoveLeft;
    }

    IEnumerator DisableGroundCollision(Collision col,float sec)
    {
        col.collider.enabled = false;
        Debug.Log("Disabling Collision...");
        yield return new WaitForSeconds(sec);
        _movement.Duck = false;
        col.collider.enabled = true;
        Debug.Log("Collision Enabled!");
    }
}
