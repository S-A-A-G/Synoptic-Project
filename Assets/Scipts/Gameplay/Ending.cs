using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending : MonoBehaviour
{
	
	public GameScript manager;
	
	
    void OnTriggerEnter2D(Collider2D other)
    {
		if (other.gameObject.tag == "Player")
		{
			int minPoints = manager.lives * manager.enemiesKilled + Random.Range(100, 200);
			float maxPoints = minPoints * 1.2f;
			manager.AddPoints(minPoints, Mathf.RoundToInt(maxPoints));
			manager.playerEnd = GameScript.playerEndState.Win;
			manager.ActivateGameOverScreen();
		}
		
		
        
		
    }
}
