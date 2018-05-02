using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//(C) Tyler Wargo - 2018

public class QuestionManager : MonoBehaviour 
{
	public int score = 0;
	public bool allowGameNR = true;
	public int nextQuestionInEditor;

	public void changeQuestion(int nextQuestion)
	{
		SceneManager.LoadScene (nextQuestion);
	}

	//Wrong Answer
	public void incorrect()
	{
		//Subtracts Score
		score -= 1;
		//Disallows Minigame
		allowGameNR = false;

		Debug.Log ("Incorrect - " + score);
	}

	//Correct Answer
	public void correctCheck()
	{
		if (allowGameNR == true) 
		{
			Debug.Log ("Move On To Minigame");
			MinigameController.nextMinigameQuestion = nextQuestionInEditor;
			SceneManager.LoadScene ("Minigame");
		} else 
		{
			Debug.Log ("Move On To Next Question");
			changeQuestion (nextQuestionInEditor);
		}
	}

	//Restart Function
	public void restart()
	{
		SceneManager.LoadScene ("Title");
	}

	public void Update()
	{
		//Restarts if two attempts missed
		if (score <= -2) 
		{
			restart ();
		}
	}
}
