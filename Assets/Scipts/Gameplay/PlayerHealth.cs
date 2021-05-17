using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
	
	
	public GameObject player;
	public GameScript manager;
    public GameObject respawnPoint;
	
	void Update()
	{
		if(manager == null)
		{
			manager =  GameObject.Find("Manager").GetComponent<GameScript>();
			
		}
		if(respawnPoint)
		{
			respawnPoint =  GameObject.Find("RespawnPoint");
			
		}
		
		
	}
	
	
	

	void OnCollisionEnter2D(Collision2D other)
	{
			if(other.collider.enabled && other.collider.CompareTag("Enemy") || other.collider.CompareTag("DangerObstacle"))
			{
				if(other.gameObject.GetComponent<FireballProjectile>() != null)
				{
					Destroy(other.gameObject);
				}
				DecreaseHealth(1);
			}
	}
	
	public void DecreaseHealth(int amount)
	{
		manager.lives = manager.lives - amount;
		manager.UpdateHearts();

		Death();

	}

	
	public void Death()
	{
		
		manager.AddPoints(-200, -100);
		
		if(manager.lives <= 0)
		{
				manager.playerEnd = GameScript.playerEndState.Lose;
				manager.ActivateGameOverScreen();
		}
		else{
			
			//Respawn
			player.transform.position = respawnPoint.transform.position;
		}
		
	}
	
}
