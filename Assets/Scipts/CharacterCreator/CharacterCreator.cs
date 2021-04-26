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
	public OutfitList[] list = new OutfitList[2];
	
    public SpriteRenderer[] clothing = new SpriteRenderer[6];
	
	public string clothingType;




    void Start()
    {
        OnOptionChanged(0);
    }

	
	
    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void RandomiseChar()
    {
		 foreach (OutfitList clothing in list)
		 {
			 
			clothing.bodyPart.sprite = clothing.options[Random.Range(0, 4)];
		 }
    }
	
    public void ResetChar()
    {
		SceneManager.LoadScene(1);
    }
	

	
	
	 public void PlayGame()
    {
        PrefabUtility.SaveAsPrefabAsset(character, "Assets/PlayerPrefabs/Player.prefab");
		SceneManager.LoadScene(2);
    }
	
	 public void OnOptionChanged(int value)
    {
        colourPicker.sprite = clothing[value];
    }
	
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
	
	
}

