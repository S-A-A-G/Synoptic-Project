using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
	
	GameScript script;
	bool addedKill = false;
	
	void Start()
	{
		GameObject gameObjectManager = GameObject.Find("Manager");

		script = gameObjectManager.GetComponent<GameScript>();
	}

	void OnTriggerEnter2D(Collider2D other)
    {
		
		
		if (other.CompareTag("Player"))
		{
			Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
			rb.AddForce(Vector2.up * 5.0f);
			
			CapsuleCollider2D bc = transform.parent.gameObject.GetComponent<CapsuleCollider2D>();
			bc.enabled = false;
			
			if(!addedKill)
			{
				addedKill = true;
				script.enemiesKilled = script.enemiesKilled + 1;
				
			}
			
			
			//Destroy(transform.parent.gameObject);
			
			
			
		}
		
		
    }
}
