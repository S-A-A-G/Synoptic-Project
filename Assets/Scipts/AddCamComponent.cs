using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCamComponent : MonoBehaviour
{

    public CameraScript camera;
    


	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
            if (!camera.FocusOnPlayer)
                
            {
				camera.FocusOnPlayer = true;
			}
			//Destroy(gameObject);
		}



	}

}
