using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class SavePlayer : MonoBehaviour
{
    public GameObject character;
    public void PlayGame()
    {
        PrefabUtility.SaveAsPrefabAsset(character, "Assets/PlayerPrefabs/Player.prefab");
        SceneManager.LoadScene(2);
    }
}
