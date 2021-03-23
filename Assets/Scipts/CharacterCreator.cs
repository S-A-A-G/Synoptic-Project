using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement; //For Opening Levels
using UnityEngine.UI;


public class CharacterCreator : MonoBehaviour
{
	
	public GameObject character;
	
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	
	 public void PlayGame()
    {
        //PrefabUtility.SaveAsPrefabAsset(character, "Assets/Player.prefab");
		SceneManager.LoadScene(2);
    }
	
}

