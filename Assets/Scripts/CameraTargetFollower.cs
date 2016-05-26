using UnityEngine;
using System.Collections;

public class CameraTargetFollower : MonoBehaviour 
{
    [SerializeField]private Transform _target;
    [SerializeField]private float _damping;
    [SerializeField]private Vector3 _offset;
    private float _newYPos;
    private Vector3 _newPos;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
    {
        _newPos = new Vector3(_target.position.x - _offset.x, _newYPos, -10f);
        transform.position = Vector3.Lerp(transform.position, _newPos, _damping * Time.deltaTime);

        if(_target.position.y > 0f)
        {
            _newYPos = _target.position.y;
        }
        else
        {
            _newYPos = 0f;
        }
	}
}
