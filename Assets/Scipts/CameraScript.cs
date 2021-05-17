using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
   public GameObject player;
	public bool FocusOnPlayer = false;

	void Start()
	{
		player = GameObject.Find("CharacterCreator/Canvas/Panel/CustomChar");
	}
   
   private void FixedUpdate()
   {
		if(FocusOnPlayer)
		transform.position = Vector3.Lerp(transform.position, player.transform.position + new Vector3(0,0,-10), 4 * Time.fixedDeltaTime );
	   
   }
}
