using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour 
{
	private float buttonWidth = 265f;
	private float buttonHeight= 128f;

	public GUITexture play;
	public GUITexture credits;

	void OnGUI()
	{
		if(GUI.Button(new Rect(Screen.width /2 - 132.5f ,300 ,buttonWidth,buttonHeight),"Play!"))
		{
			Debug.Log("play!");
			Application.LoadLevel(1);
		}

		if(GUI.Button(new Rect(Screen.width /2 - 132.5f ,438 ,buttonWidth,buttonHeight),"Credits"))
		{
			Debug.Log("credits");
			//Application.LoadLevel("Level 1");
		}
	}
}

//GUI.Button(new Rect(Screen.width * (1f/6.55f),Screen.height * (0.1f/6.3f),Screen.width * (4.8f/6.55f), Screen.height * (0.85f/6.3f)),"Click"); //c#