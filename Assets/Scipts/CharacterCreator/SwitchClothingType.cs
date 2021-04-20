using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;



public class SwitchClothingType : MonoBehaviour
{
		//For Button switching between dropdowns or scroll views
    public GameObject options;
    public List<GameObject> otherOptions = new List<GameObject>();
    public Color buttonColor = Color.white;
    public Color selectedColor = Color.red;
	
	public CharacterCreator cc;
	public ClothingButtonGrid grid;
	
	
	//ClothingButtonGrid gridToGoTo;
		
    // Update is called once per frame
	
	
	//Repopulate if not on same clothing type
	//Remove all the old button children		grid.PopulateDropdown(grid.myDropdown, grid.options);
	//Outfit List
    public void OnButtonSwitched()
    {
	

/*
	
		if(clothingType == "Head")
		{
			//grid.outfitlist = GameObject.Find("BODYButton").GetComponent<OutfitList>();
			gridToGoTo = GameObject.Find("HeadScrollView").GetComponent<ClothingButtonGrid>();
			//grid.options = body.options;
			grid.PopulateDropdown(grid.myDropdown, gridToGoTo.options);
		}
					
		else if(clothingType == "Body")
		{
			///grid.outfitlist = GameObject.Find("BODYButton").GetComponent<OutfitList>();
			
			gridToGoTo = GameObject.Find("BodyScrollView").GetComponent<ClothingButtonGrid>();
			//grid.options = body.options;
			grid.PopulateDropdown(grid.myDropdown, gridToGoTo.options);
		}*/
							

	
	

      foreach (GameObject choices in otherOptions)
        {
            //choices.transform.parent.GetComponent<Image>().color = buttonColor;
            choices.SetActive(false);
            //choices.GetComponent<Button>().GetComponent<Image>().color = buttonColor;
        }


        if (options.activeSelf == true)
        {
            //this.GetComponent<Image>().color = buttonColor;
    
            options.SetActive(false);
        
        }
        else
        {
            options.SetActive(true);
          
            //this.GetComponent<Image>().color = selectedColor;
          
        }
			
		cc.clothingType = EventSystem.current.currentSelectedGameObject.name;
		
		cc.ChangeClothingCategory();
		
    }
}
