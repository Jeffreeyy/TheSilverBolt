using UnityEngine;
using System.Collections;

public class EnemyDetect : MonoBehaviour {

    private float _targetingRadius = 2f;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        //Collider col = Physics.OverlapSphere(transform.position, _targetingRadius);
        
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(this.transform.position, _targetingRadius);
    }
}
