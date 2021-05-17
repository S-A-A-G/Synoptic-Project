using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
	
	public GameObject pauseUI;
	public bool isPaused;
   
   private void Update()
   {
	   if(Input.GetKeyDown(KeyCode.P))
	   {
		   if(!isPaused)
		   {
			   ActivateMenu();
		   }
	   }
	
   }
   
   void ActivateMenu()
   {
		isPaused = true;
		Time.timeScale = 0;
		AudioListener.pause = true;
	    pauseUI.SetActive(true);
   }
   
   void DeactivateMenu()
   {
		isPaused = false;
	   	Time.timeScale = 1;
		AudioListener.pause = false;
	    pauseUI.SetActive(false);
		
	   
   }
   
   
   public void ResumeGame()
   {
	  DeactivateMenu();
   }
   
   public void BackToMainMenu()
   {
	   
	  SceneManager.LoadScene(0);
   }
   
    public void QuitGame()
   {
	   
	  Application.Quit();
   }
}
