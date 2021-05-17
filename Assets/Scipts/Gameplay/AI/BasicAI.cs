using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAI : MonoBehaviour
{
	
   	//Movement
	public float walkSpeed = 1f;
	bool isFacingRight = true;
	
	public bool hasFireballAbility = false;
	public bool canShootFireball = false;
	public GameObject shoot;
	
	public GameObject fireball;

    float horizontalMovement;
	public GameObject groundObject;
	
	
	RaycastHit2D lineTraceGround;
	RaycastHit2D lineTraceForward;


	Rigidbody2D rb;

	void Start()
	{
		rb  = GetComponent<Rigidbody2D>();
		
	}
	void Update()
	{
		 Move();

		DetectPlayer();
		 
		 
	}
	
	
	void Move()
	{
		transform.Translate(Vector2.right * walkSpeed * Time.deltaTime);
		
		//Linetrace to detect ground
		lineTraceGround = Physics2D.Raycast(groundObject.transform.position, Vector2.down,5f);
		
		if(!lineTraceGround.collider){
			if(isFacingRight) {
				
				transform.eulerAngles = new Vector3(0,-180,0);
				isFacingRight = false;
			}
			else{	
				
				transform.eulerAngles = new Vector3(0,0,0);
				isFacingRight = true;
			}
			
		}
	}
	
	void DetectPlayer()
	{
		lineTraceForward = Physics2D.Raycast(shoot.transform.position, shoot.transform.right, 5f);
		
		if(lineTraceForward.collider.CompareTag("Player"))
		{
			
			if(hasFireballAbility) ShootFireball();
	
		}
		
		/*if(lineTraceForward.collider.CompareTag("Enemy"))
		{
			
			if(isFacingRight) {
				
				transform.eulerAngles = new Vector3(0,-180,0);
				isFacingRight = false;
			}
			else{	
				
				transform.eulerAngles = new Vector3(0,0,0);
				isFacingRight = true;
			}
	
		}*/
	}
	
	void ShootFireball()
	{
		
			if(canShootFireball)
			{
				
				StartCoroutine(DeployOneFireBall());
				
			}
				
	}
	
	IEnumerator DeployOneFireBall()
    {
		 GameObject fireballInstance = Instantiate(fireball, shoot.transform.position, shoot.transform.rotation) as GameObject;
		 FireballProjectile fireballScript = fireballInstance.GetComponent<FireballProjectile>();
		
		fireballScript.right = isFacingRight;
		
		canShootFireball = false;

     
        yield return new WaitForSeconds(3);

  		canShootFireball = true;

    }

	


}
