using UnityEngine;
using System.Collections;
//兔子的控制代码
public class ETPlayer : MonoBehaviour {



	void FixedUpdate()
	{

	}
	void OnEnable(){
		EasyJoystick.On_JoystickMove += On_JoystickMove;	
		EasyJoystick.On_JoystickMoveEnd += On_JoystickMoveEnd;
		EasyButton.On_ButtonUp += On_ButtonUp;	
	}

	void Fire(){

	}


	void OnDisable()
	{
		EasyJoystick.On_JoystickMove -= On_JoystickMove;	
		EasyJoystick.On_JoystickMoveEnd -= On_JoystickMoveEnd;
		EasyButton.On_ButtonUp -= On_ButtonUp;	
	}
		
	void OnDestroy()
	{
		EasyJoystick.On_JoystickMove -= On_JoystickMove;	
		EasyJoystick.On_JoystickMoveEnd -= On_JoystickMoveEnd;
		EasyButton.On_ButtonUp -= On_ButtonUp;	
	}

	
	void On_JoystickMove( MovingJoystick move)
	{
	//摇杆控制
	
		float angle = move.Axis2Angle(true);//获得旋转角度
		if(angle>-35.0f&&angle<35.0f)
		{
			transform.Translate (new Vector3 (1, 0, 0) * -2 * Time.deltaTime);
			GetComponent<Animator> ().SetFloat ("speed", 0.5f);
			//GetComponent<Animator> ().Play ("WalkStart");
		}
		if(angle>-140.0f&&angle<-10.0f)
		{
			transform.Rotate (new Vector3(0,1,0)*-20*Time.deltaTime);//右转
		}
		else if(angle<140.0f&&angle>10.0f)
		{
			transform.Rotate (new Vector3(0,1,0)*20*Time.deltaTime);//左转
		}
	}

	void On_JoystickMoveEnd (MovingJoystick move)
	{
		//GetComponent<Animator> ().Play ("Idle");
		GetComponent<Animator> ().SetFloat ("speed", 0);
	}
	

	
	void On_ButtonUp (string buttonName)
	{
	}	
}
