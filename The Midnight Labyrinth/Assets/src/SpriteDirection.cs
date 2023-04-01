using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class SpriteDirection : MonoBehaviour
{
    public AIPath aiPath;
    private SpriteRenderer spriteRenderer;

    Animator enemyanimator;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        enemyanimator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        if (aiPath.desiredVelocity.x != 0.00f || aiPath.desiredVelocity.y != 0.00f){
            enemyanimator.SetBool("isTracking", true);
        }
        else{
            enemyanimator.SetBool("isTracking", false);
            }

        
        
        if (aiPath.desiredVelocity.x >= 0.01f)
        {
            spriteRenderer.flipX = false;
        }
        else if (aiPath.desiredVelocity.x <= -0.01f)
        {
            spriteRenderer.flipX = true;
        }
    }
}