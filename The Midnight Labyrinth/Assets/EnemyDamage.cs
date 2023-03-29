using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    // pulling function rom PlayerHealth class.
    public PlayerHealth playerHealth;
    public int damage = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // This class gives damage when enemy collides with the enemy.
   
    void OnCollisionEnter2D(Collision2D other) {
            if(other.gameObject.tag == "Player")
            {
                playerHealth.TakeDamage(damage);
            }
            Debug.Log("Hit!");
        }
    
}
