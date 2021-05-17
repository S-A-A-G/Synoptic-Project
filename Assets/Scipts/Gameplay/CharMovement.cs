using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMovement : MonoBehaviour
{
	
	//allows the script to access the animator to switch animations
    public Animator animator;
	
	//Movement
	public int walkSpeed = 5;
	bool isFacingRight = true;
	
	//a variable with a default value to allow communication betweenUpdate and FixedUpdate
    float horizontalMovement;

	
	//Jumping and Falling
	public GameObject groundCheckObject;
	public LayerMask groundLayer;
	
	public bool isOnGround = false;
    public bool isJumping = false;
	public int jumpForce = 250;
	
	
	private Rigidbody2D playerRigidBody;

	public ParticleSystem footDust;

	private void Awake()
	{
		playerRigidBody = GetComponent<Rigidbody2D>();

	}

    // Update is called once per frame
    void Update()
    {
		//Gets Y velocity for the Jumping to Landing Transition
		animator.SetFloat("JumpVelocity",playerRigidBody.velocity.y);
		
		GroundCheck();
        Move();
		
    }
	

	
	
	void Move()
	{
		horizontalMovement = Input.GetAxis("Horizontal");
		
		
		//Flips player to face the right way
		if(horizontalMovement < 0.0f && isFacingRight) Flip();
		else if(horizontalMovement > 0.0f && !isFacingRight) Flip();
		
		
		if(Input.GetButtonDown("Jump"))
		{
			isJumping = true;
			
			if(isOnGround)
			{
				
				Jump();
			}
			
		}			

		//Moves player location
		playerRigidBody.velocity = new Vector2(horizontalMovement * walkSpeed, playerRigidBody.velocity.y);
		animator.SetFloat("Speed", Mathf.Abs(horizontalMovement));
	}
	
	
	void Jump()
	{
		footDust.Play();
		playerRigidBody.AddForce(Vector2.up  * jumpForce);
		animator.SetBool("IsJumping", true);
	}
	
	
	
	void Flip()
	{
		// Switch the way the player is labelled as facing.
		isFacingRight = !isFacingRight;

		// Multiply the player's x local scale by -1.
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
		
	}
	
	void GroundCheck()
	{
		isJumping = true;
		isOnGround = false;
		
		Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheckObject.transform.position, 0.2f, groundLayer);
		
		if(colliders.Length > 0)
		{
			isJumping = false;
			isOnGround = true;
			
		
		}
		
		animator.SetBool("IsJumping", !isOnGround);

			
	}
	

}
