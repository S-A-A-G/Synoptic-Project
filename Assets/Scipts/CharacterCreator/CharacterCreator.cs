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

	public OuttfitList[] list = new OuttfitList[2];
	
    public SpriteRenderer[] clothing = new SpriteRenderer[6];




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
		 foreach (OuttfitList clothing in list)
		 {
			 
			clothing.bodyPart.sprite = clothing.options[Random.Range(0, 2)];
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
	
	
}

