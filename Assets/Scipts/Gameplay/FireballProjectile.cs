using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballProjectile : MonoBehaviour
{
	
	public float moveSpeed = 8f;
	public bool right = true;
	
    // Start is called before the first frame update
    void Start()
    {
		
		
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
	
	public void Move()
	{
		if(right)
		{
			transform.position = new Vector3( transform.position.x + (moveSpeed * Time.deltaTime), transform.position.y, transform.position.z);
		}
		else{
			transform.position = new Vector3( transform.position.x + (-moveSpeed * Time.deltaTime), transform.position.y, transform.position.z);
		}
	}
	

	
	
}
