using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutfitList : MonoBehaviour
{
   //public TMPro.TMP_Dropdown myDropdown;


    [Header("Sprite To Change")]
    public SpriteRenderer bodyPart;

    [Header("Sprites To Cycle Through")]
    public List<Sprite> options = new List<Sprite>();

  

    // Start is called before the first frame update
    void Start()
    {

       //PopulateDropdown(myDropdown, options);

    }

/*
    void PopulateDropdown(TMPro.TMP_Dropdown dropdown, List<Sprite> optionsArray)
    {
        List<string> options = new List<string>();
        foreach (var option in optionsArray)
        {
            options.Add(option.name); 
        }
        dropdown.ClearOptions();
        dropdown.AddOptions(options);
    }*/

    public void OnOptionChanged(int value)
    {

        bodyPart.sprite = options[value];
    }
}
