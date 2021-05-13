using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//This will be for clicking on the button, changes the sprite of the player
public class ButtonSprite : MonoBehaviour
{
	
	public Sprite buttonSprite;
	
	[Header("Sprite To Change")]
    public List<SpriteRenderer> bodyPart;
	
	Image newImage;
    // Start is called before the first frame update
    void Start()
    {
       newImage =  this.transform.Find("Image").GetComponent<Image>();
	   newImage.sprite = buttonSprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	
	public void updateCharacter()
	{
		//Here we can  probably use similar code from Outfit List class... The sprite change. 
		//We would have to consider when changing hands we change it for left and right , anything symmetrical
		
		foreach(SpriteRenderer bodyFeature in bodyPart)
		{
				bodyFeature.sprite = buttonSprite;
	}

		
		
	}
		
}
