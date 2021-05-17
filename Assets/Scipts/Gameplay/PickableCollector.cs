using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableCollector : MonoBehaviour
{
	
	
	GameScript gameManager;
	public enum CollectableType {Points, Lives};
	public CollectableType currentOption;
  
	void Start()
	{
	  gameManager = GameObject.Find("Manager").GetComponent<GameScript>();
	}
	
	void OnTriggerEnter2D(Collider2D other)
    {
		if (other.gameObject.tag == "Player")
		{
			switch (currentOption)
 
			{
 
				case CollectableType.Points:
	 
				{
					PointsEvent();
					break;
				}
				
				case CollectableType.Lives:
				{
					LivesEvent();
					break;
				}

			}
			 Destroy(gameObject);
		}			
		
		
    }
	
	public void PointsEvent()
	{
		float chance = Random.value;
		if(chance > 0.95)
		{
			gameManager.AddPoints(1000,2500);
		}
		else if (chance > 0.4 && chance <= 0.95 )
		{
			gameManager.AddPoints(200,500);
		}
		else
		{
			gameManager.AddPoints(-200,100);
		}
		
		
		
	}
	
	public void LivesEvent()
	{
		if(gameManager.lives ==  3)
		{
			
			gameManager.lives = Random.Range(1,3);;
		
		}
		else{
			gameManager.lives += 1;
		}
		gameManager.UpdateHearts();
	}
}
