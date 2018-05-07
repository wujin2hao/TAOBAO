using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour 
{
	public void PlayButton()
	{
		SceneManager.LoadScene ("Game");
	}
	public void QuitButton()
	{
		Application.Quit ();
	}
	public void WorkersButton()
	{
		SceneManager.LoadScene ("Workers");
	}
	public void BackButton()
	{
		SceneManager.LoadScene ("MainMenu");
	}

}
