using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ClothingButtonGrid : MonoBehaviour
{
	
	public GameObject button;
	public OutfitList outfitlist;
	public List<GameObject> buttonArray;
	public Dropdown myDropdown;


    [Header("Clothing Categories")]
    public List<string> options = new List<string>();
	
    // Start is called before the first frame update
    void Start()
    {
		PopulateDropdown(myDropdown, options);
        PopulateGrid();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	 public void PopulateDropdown(Dropdown dropdown, List<string> optionsArray)
    {
        List<string> options = new List<string>();
        foreach (var option in optionsArray)
        {
            options.Add(option); 
        }
        dropdown.ClearOptions();
        dropdown.AddOptions(options);
    }
	
	
	public void PopulateGrid()
	{
	
		 GameObject currButton;
		 /*
		 if(buttonArray.Count > 0)
		 {
			 
			foreach (GameObject tempButton in buttonArray)
			{
				//Destroy(tempButton);
				buttonArray.Remove(tempButton);
			}
		 }*/
			
		
	
		 int buttonAmount = outfitlist.options.Count;

		
		 
		 for (int i = 0; i < buttonAmount; i++)
		 {
			
			 currButton = (GameObject)Instantiate(button, transform);
			 currButton.GetComponent<Image>().color = Random.ColorHSV();
			  
			 //Image buttonImage = transform.Find("Image").GetComponent<Image>();
			 //buttonImage.sprite = outfitlist.options[i];
			 buttonArray.Add(currButton);
			 

	
		 }
		 
		
		 
		 
		 
		 
	
 
		 
		 
	}
	

	
}
