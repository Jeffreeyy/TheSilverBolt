using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

    private float _health = 100;
    private float _currentHealth;
	// Use this for initialization
	void Start () {
        _currentHealth = _health;
	}

    public void TakeDamage(float damage)
    {
        _currentHealth -= damage;
        if(_currentHealth <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
