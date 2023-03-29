using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class SpriteDirection : MonoBehaviour
{
    public AIPath aiPath;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
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