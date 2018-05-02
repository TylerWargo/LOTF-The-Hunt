using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PigInteraction : MonoBehaviour 
{
	void OnMouseDown()
	{
		SceneManager.LoadScene (MinigameController.nextMinigameQuestion);	
	}
}
