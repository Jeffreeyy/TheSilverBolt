using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    [SerializeField]private Transform _player;
    private Camera _camera;
    
    [Range(-50f, 50f)]
    [SerializeField]private float _xOffset = 0;

    [Range(-50f, 50f)]
    [SerializeField]private float _yOffset = 0;

    [Range(-50f, 50f)]
    [SerializeField]private float _zOffset = 10;

    [SerializeField]private bool _hardFollow = true;

    private float dampTime = 0.2f;
    private Vector3 velocity = Vector3.zero;

	// Use this for initialization
	void Start () 
    {
        _camera = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void LateUpdate () 
    {
        if(_hardFollow)
        {
            HardFollow();
        }
        else
        {
            SmoothFollow();
        }
	}

    void SmoothFollow()
    {
        if (_player)
        {
            Vector3 point = _camera.WorldToViewportPoint(_player.transform.position);
            Vector3 delta = _player.transform.position - _camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z));
            Vector3 destination = transform.position + delta;
            transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
        }
    }

    void HardFollow()
    {
        transform.position = new Vector3(_player.transform.position.x - _xOffset, _player.transform.position.y - _yOffset, _player.transform.position.z - _zOffset);
    }
}
