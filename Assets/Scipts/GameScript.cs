using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour
{
	
	 public GameObject Player;
	  public GameObject groundChecker;
	 public CharMovement playerMovement;
	 
	 
	 //Game Over Screen
	 public GameObject gameOverUI;
	 public TextMeshProUGUI winLoseText;
	 public TextMeshProUGUI totalScore;
	 public TextMeshProUGUI enemiesKilledText;
	 public TextMeshProUGUI LivesLeftText;

	public enum playerEndState {Neutral, Win, Lose};
	public playerEndState playerEnd = playerEndState.Neutral;
  
	 
	 
	 
	 //Points
	 public int points;
	 public TextMeshProUGUI pointsText;
	 
	 //Lives
	 public GameObject[] hearts = new GameObject[3]; 
	 public int lives = 3;
  
  
	//Other Stats
	 public int enemiesKilled = 0;


	 
    // Start is called before the first frame update
    void Start()
    {
		//SaveSystem.LoadCharacter();
		//playerMovement.groundCheckObject = groundChecker;
		//playerMovement.groundLayer = LayerMask.GetMask("Ground");
		
		points = 0;
		UpdatePointsText();
		UpdateHearts();

		


    }

    // Update is called once per frame
    public void AddPoints(int minAmount, int maxAmount)
    {
		//For Killing Enemies around 200-250, Any Points collected will be 100-150, For Completeing level 500
        points += Random.Range(minAmount, maxAmount);
		UpdatePointsText();
    }

	
	public void UpdatePointsText()
	{
		pointsText.SetText("Points: " + points.ToString());
	}
	
	public void UpdateHearts()
   {
	   if(lives > 3)
	   {
		   lives = 3;
	   }
	   
	   switch(lives)
	   {
			case 3: 
				hearts[0].SetActive(true);
				hearts[1].SetActive(true);
				hearts[2].SetActive(true);
				break;
			
			case 2:
			    hearts[0].SetActive(true);
				hearts[1].SetActive(true);
				hearts[2].SetActive(false);
				break;	
					
			case 1:
			    hearts[0].SetActive(true);
				hearts[1].SetActive(false);
				hearts[2].SetActive(false);
				break;
				
			case 0:
			    hearts[0].SetActive(false);
				hearts[1].SetActive(false);
				hearts[2].SetActive(false);

					
				break;
				
	   }
   }
   
   
   public void ActivateGameOverScreen()
   {
	   gameOverUI.SetActive(true);
	   Time.timeScale = 0;
	   switch (playerEnd)
 
			{
 
				case playerEndState.Win:
	 
				{
					EndWin("YOU WIN");
					break;
				}
				
				case playerEndState.Lose:
				{
					EndWin("YOU LOSE");
					break;
				}

			}
   }
   
   public void EndWin(string PlayerWin)
   {
	   winLoseText.SetText(PlayerWin);
	   totalScore.SetText("TOTAL SCORE: " +  points);
	   enemiesKilledText.SetText("ENEMIES KILLED: " + enemiesKilled);
	   LivesLeftText.SetText("LIVES LEFT: " +  lives);

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

