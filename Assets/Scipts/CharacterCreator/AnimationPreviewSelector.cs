using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPreviewSelector : MonoBehaviour
{
	public TMPro.TMP_Dropdown myDropdown;



    [Header("Sprites To Cycle Through")]
    public List<Animation> options = new List<Animation>();
	
	public Animator animator;
    


    // Start is called before the first frame update
    void Start()
    {
		//animator = GetComponent<Animator>();
       // PopulateDropdown(myDropdown, options);

    }


    void PopulateDropdown(TMPro.TMP_Dropdown dropdown, List<Animation> optionsArray)
    {
        List<string> options = new List<string>();
        foreach (var option in optionsArray)
        {
            options.Add(option.name); 
        }
        dropdown.ClearOptions();
        dropdown.AddOptions(options);
    }

    public void OnOptionChanged(int value)
    {
		animator.SetInteger("AnimState", value);
		
		/*if(value == 0)
		{		
		animator.SetInteger("AnimState", 0);
		}
		else if(value == 1)
		{		
		animator.SetInteger("AnimState", 1);
		}
		
		else if(value == 2)
		{		
		animator.SetInteger("AnimState", 2);
		}
		
		else if(value == 3)
		{		
		animator.SetInteger("AnimState", 3);
		}
*/



    }
}
