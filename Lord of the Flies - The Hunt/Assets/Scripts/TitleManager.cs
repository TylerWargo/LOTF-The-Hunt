﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour 
{
	public void changeScene(int sceneTo)
	{
		SceneManager.LoadScene (sceneTo);
	}
}
