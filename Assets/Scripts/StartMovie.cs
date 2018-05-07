using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartMovie : MonoBehaviour 
{
	private float time;
	void FixedUpdate()
	{
		time += Time.deltaTime;
		if(time>=10.5f)
		{
			time = 0;
			SceneManager.LoadScene ("MainMenu");
		}
	}
}
