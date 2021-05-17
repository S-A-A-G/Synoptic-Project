using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDeath : MonoBehaviour
{


	public PlayerHealth health;
	
	
	void OnTriggerEnter2D(Collider2D other)
    {
		if (other.gameObject.tag == "Player")
		{
			health.DecreaseHealth(1);
		}
		else{
			Destroy(other);
		}
		
        
		
    }

}
