using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public float moveSpeed = 1f;
    public Rigidbody2D rb;
    public Animator animator;
    
    Vector2 movement;
    
    
    
    void setVelocity() {
        
        if (movement.x < 0.3 && movement.y < 0.3 && movement.x > -0.3 && movement.y > -0.3) {
            moveSpeed = Mathf.Max(moveSpeed - 0.5f, 0);
        } else if (moveSpeed < 5) {
            moveSpeed += 0.5f;
        }

        rb.velocity = movement * moveSpeed;
    }
    
    // Update is called once per frame
    void Update()
    {
        //Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical"); 
        
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }
    
    void FixedUpdate() {
        // movement
        setVelocity();
        
        
    }
}
