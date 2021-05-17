using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
   public GameObject player;
   
   
   private void FixedUpdate()
   {
	   transform.position = Vector3.Lerp(transform.position, player.transform.position + new Vector3(0,0,-10), 4 * Time.fixedDeltaTime );
	   
   }
}
