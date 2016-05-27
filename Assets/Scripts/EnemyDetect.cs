using UnityEngine;
using System.Collections;

public class EnemyDetect : MonoBehaviour {

    private float _targetingRadius = 2f;
    [SerializeField]private float enemyY;
    [SerializeField]private float moveSpeed;
    private Transform target;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        Collider[] objectsInRange = Physics.OverlapSphere(transform.position, _targetingRadius);
        foreach(Collider col in objectsInRange)
        {
            if(col.name == "Player")
            {
                //move to player
                target = col.transform;
                float dist = Vector3.Distance(transform.position, target.position);
                if(dist > 0.3)
                {
                    float playerX = target.position.x;
                    transform.position = Vector3.MoveTowards(transform.position, new Vector3(playerX, enemyY, 0), moveSpeed * Time.deltaTime);
                }
            }
        }
        
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(this.transform.position, _targetingRadius);
    }
}
