using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement; //For Opening Levels
using UnityEngine.UI;
using HSVPicker.Examples;


public class CharacterCreator : MonoBehaviour
{
	
	public GameObject character;
	

    //SpriteRenderer spriteRender;
    public ColorPickerTester colourPicker;

	//For Randomisation to work
	public Sprite[] legsSprites;
	public SpriteRenderer leftLeg;
	public SpriteRenderer rightLeg;


	public List<GameObject> headPanels = new List<GameObject>(); 
	public List<GameObject> eyeTypePanels = new List<GameObject>(); 
	public SpriteRenderer eyeBase;
	public List<Sprite> eyeTypeSprites = new List<Sprite>();
	
	
	public List<GameObject> colourableScrollviews = new List<GameObject>(); 
	 public List<SpriteRenderer> spritesToColourIn = new List<SpriteRenderer>(); 
    public SpriteRenderer[] clothing = new SpriteRenderer[6];
	


	public List<GameObject> invisFloors;
	public Camera cam1;
	public Camera cam2;



	void Start()
    {
		cam1.gameObject.SetActive(true);
		cam2.gameObject.SetActive(false);
		cam1.enabled = true;
		cam2.enabled = false;
	}

	
	
    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void RandomiseChar()
    {

			Sprite randomLeg = legsSprites[Random.Range(0, legsSprites.Length)];
			rightLeg.sprite = randomLeg;
			leftLeg.sprite = randomLeg;
	}
	
	
	public void UpdateColourPickerSprite()
	{
		
		//We can do an if statement for all panels... Well 8 scrollviews
		//Hat could be ClothingOptions[0] , well.. only the ones that needs to be coloured in... anything else,disables the colour wheel.
	
	
	//HAT
		if(colourableScrollviews[0].activeSelf == true)
		{
			colourPicker.sprite = spritesToColourIn[0];
		}
		
	//EYE IRIS
		else if(colourableScrollviews[1].activeSelf == true)
		{
			colourPicker.sprite = spritesToColourIn[1];
		}
	//MOUTH
	
	//TORSO
	
	
	//LEGS
		
	}
	

	
	
    public void ResetChar()
    {
		SceneManager.LoadScene(1);
    }
	
	
	public void FocusHeadPartsDropdown(int value)
	{
		
			
	    foreach (GameObject headPart in headPanels)
        {  
             headPart.SetActive(false); 
        }      

		//We want to set the right panel active depending on the dropdown value.
		GameObject currentHeadPart = headPanels[value];
		currentHeadPart.SetActive(true);
		UpdateColourPickerSprite();
	}

	
	
	 public void PlayGame()
    {
		//PrefabUtility.SaveAsPrefabAsset(character, "Assets/PlayerPrefabs/Player.prefab");

		//SaveSystem.SaveGame(this);
		//SceneManager.LoadScene(2);
		cam1.gameObject.SetActive(false);
		cam2.gameObject.SetActive(true);
		cam1.enabled = false;
		cam2.enabled = true;

		foreach (GameObject floorDisable in invisFloors)
		{
			floorDisable.SetActive(false);
		}
	}
	
	 //public void OnOptionChanged(int value)
   // {
        //colourPicker.sprite = clothing[value];
   // }
	
	/*
	public void ChangeClothingCategory()
	{
		
		if(clothingType == "HEADButton")
		{

			grid = GameObject.Find("HeadScrollView").GetComponentInChildren<ClothingButtonGrid>();
			grid.PopulateDropdown(grid.myDropdown, grid.options);
		}
					
		else if(clothingType == "BODYButton")
		{
			
			grid = GameObject.Find("BodyScrollView").GetComponentInChildren<ClothingButtonGrid>();
			grid.PopulateDropdown(grid.myDropdown, grid.options);
		}
		
		else if(clothingType == "ARMSButton")
		{
			
			grid = GameObject.Find("ArmsScrollView").GetComponentInChildren<ClothingButtonGrid>();
			grid.PopulateDropdown(grid.myDropdown, grid.options);
		}

	}*/
	
	
	//This is when we swap categories, we would need to update the outfit list... so it can update the grid of buttons
	public void UpdateOutfitList()
	{
		
	}
	
	
	public void Return()
    {
      
		SceneManager.LoadScene(0);
    }
	
	
	public void SwitchEyeType(int value)
	{
		
		
		//Toggle Active of each panel
		  foreach (GameObject eyePart in eyeTypePanels)
        {  
             eyePart.SetActive(false); 
        }      

		//We want to set the right panel active depending on the dropdown value.
		GameObject currentEyePanel = eyeTypePanels[value];
		currentEyePanel.SetActive(true);
		
		eyeBase.sprite = eyeTypeSprites[value];
		UpdateColourPickerSprite();
		
	}
	
	
}

