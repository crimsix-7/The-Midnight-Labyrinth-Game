using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerHandler : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float collisionOffset = 0.02f;

    public ContactFilter2D movementFilter;
    Vector2 movementInput;
    Rigidbody2D rb;

    Animator animator;

    List<RaycastHit2D> castCollisions = new List<RaycastHit2D>();

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void FixedUpdate(){

        if (movementInput != Vector2.zero){
            bool success = TryMove(movementInput);

            if (!success){
                success = TryMove(new Vector2(movementInput.x, 0));

                 if (!success){
                    success = TryMove(new Vector2(0, movementInput.y));
                 }    
            }

            animator.SetBool("isMoving", success);
        }
        else{
            animator.SetBool("isMoving", false);
        }
    }

    private bool TryMove(Vector2 direction){
        int count = rb.Cast(
        direction, 
        movementFilter,
        castCollisions,
        moveSpeed * Time.fixedDeltaTime + collisionOffset);

        if(count == 0){
            rb.MovePosition(rb.position + direction * moveSpeed * Time.fixedDeltaTime);
            return true;
        }   
        else{
            return false;
        }
    }

    void OnMove(InputValue MovementValue){
        movementInput = MovementValue.Get<Vector2>();
    }
}
