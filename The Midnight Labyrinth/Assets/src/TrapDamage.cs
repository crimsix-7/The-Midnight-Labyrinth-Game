using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDamage : MonoBehaviour
{

    // pulling function rom PlayerHealth class.
    public PlayerHealth playerHealth;
    public int damage = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // This class gives damage when enemy collides with the enemy.
private void AnimationFinishedTrigger()
{
    Collider2D[] colliders = Physics2D.OverlapBoxAll(transform.position, transform.localScale, 0);

    foreach (Collider2D collider in colliders)
    {
        if (collider.CompareTag("Player"))
        {
            int distance = Mathf.RoundToInt(Vector2.Distance(collider.transform.position, transform.position));
            if (distance < 1) // Only consider collision if player is within 1 unit of the trap
            {
                playerHealth.TakeDamage(damage);
            }
        }
    }
}


}