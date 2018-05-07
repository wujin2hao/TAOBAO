using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//文字浮现代码
public class TextGo : MonoBehaviour {
	public GameObject player;
	public Text wenzi;
	public string neirong;
	private bool use;
	private int index;
	private float time;


	//*********
	public bool npc;// 是 NPC
	//public GameObject buttonUp;
	public GameObject buttonLeft;//画面上的按钮
	public GameObject buttonRight;
	public GameObject buttonA;//实际的按钮
	public GameObject buttonB;
	public GameObject roadA;
	public GameObject roadB;
	//*********
	void Update()
	{
		if(use)
		{
			time += Time.deltaTime;
			if(time>=0.15f){
			time = 0;
			wenzi.text+=neirong[index];
			index++;
			if(index==neirong.Length)
			{
				use = false;
				//wenzi.text = "";
			}
		}
		}
	}


	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject==player&&!use)
		{
			use = true;
			index = 0;
			wenzi.text = "";
			if(npc)
			{
				buttonLeft.SetActive (true);
				buttonRight.SetActive (true);
				buttonA.SetActive (true);
				buttonB.SetActive (true);
			}
		}
	}

	void OnTriggerExit(Collider other)
	{
		if(other.gameObject==player)
		{
			use = false;
			index = 0;
			wenzi.text = "";
			if(npc)
			{
				buttonLeft.SetActive (false);
				buttonRight.SetActive (false);
				buttonA.SetActive (false);
				buttonB.SetActive (false);
			}
		}
	}

	public void ButtonA()
	{
		roadA.SetActive (true);
		buttonLeft.SetActive (false);
		buttonRight.SetActive (false);
		buttonA.SetActive (false);
		buttonB.SetActive (false);
	}
	public void ButtonB()
	{
		roadB.SetActive (true);
		buttonLeft.SetActive (false);
		buttonRight.SetActive (false);
		buttonA.SetActive (false);
		buttonB.SetActive (false);
	}
}
