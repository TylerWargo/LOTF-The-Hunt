using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeToControls : MonoBehaviour 
{
	public void toControls()
	{
		SceneManager.LoadScene ("Controls");
	}

	public void toMenu()
	{
		SceneManager.LoadScene ("Title");
	}
}
