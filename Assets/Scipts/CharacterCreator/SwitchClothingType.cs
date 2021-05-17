using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Editor.CharacterCreator;
using UnityEngine.UI;
using UnityEngine.EventSystems;



public class SwitchClothingType : MonoBehaviour
{
		//For Button switching between dropdowns or scroll views
    public GameObject options;
    public List<GameObject> otherOptions = new List<GameObject>();
	
	public GameObject dropdownOption;
	public bool hasExtraOptions;
	
    public Color buttonColor = Color.white;
    public Color selectedColor = Color.red;
	
	public CharacterCreator cc;

		

		
    // Update is called once per frame
	
	
	//Repopulate if not on same clothing type
	//Remove all the old button children		grid.PopulateDropdown(grid.myDropdown, grid.options);
	//Outfit List
    public void OnButtonSwitched()
    {
	
		
      foreach (GameObject choices in otherOptions)
      {
            //choices.transform.parent.GetComponent<Image>().color = buttonColor;
            choices.SetActive(false);
	
            //choices.GetComponent<Button>().GetComponent<Image>().color = buttonColor;
      }

      if (options.activeSelf == false)
      {
          //this.GetComponent<Image>().color = buttonColor;
         options.SetActive(true);

     }
		

	 	


	if(hasExtraOptions)
	{
		dropdownOption.SetActive(true);
	}
	else{
	  dropdownOption.SetActive(false);
	}
		
	 cc.UpdateColourPickerSprite();
			
		//cc.clothingType = EventSystem.current.currentSelectedGameObject.name;
		
		//cc.ChangeClothingCategory();
		
    }
}

	
