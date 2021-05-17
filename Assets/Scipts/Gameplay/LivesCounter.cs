using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesCounter : MonoBehaviour
{
	
	public GameObject[] hearts = new GameObject[3]; 
	public int lives = 3;
	
    // Start is called before the first frame update
    void Start()
    {

        UpdateHearts();
    }

   public void UpdateHearts()
   {
	   if(lives > 3)
	   {
		   lives = 3;
	   }
	   
	   switch(lives)
	   {
			case 3: 
				hearts[0].SetActive(true);
				hearts[1].SetActive(true);
				hearts[2].SetActive(true);
				break;
			
			case 2:
			    hearts[0].SetActive(true);
				hearts[1].SetActive(true);
				hearts[2].SetActive(false);
				break;	
					
			case 1:
			    hearts[0].SetActive(true);
				hearts[1].SetActive(false);
				hearts[2].SetActive(false);
				break;
				
			case 0:
			    hearts[0].SetActive(false);
				hearts[1].SetActive(false);
				hearts[2].SetActive(false);
				Time.timeScale = 0;
					
				break;
				
	   }
   }
   
}
