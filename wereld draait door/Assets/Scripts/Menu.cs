using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour 
{
	private float buttonWidth = 200f;
	private float buttonHeight= 200f;

	public string name;

	void OnGui()
	{
		/*if(GUI.Button(new Rect(Screen.width/2,Screen.height/2, buttonWidth, buttonHeight)),name)
		{
			Application.LoadLevel("Level1");
		}*/

		if(GUI.Button(new Rect(Screen.width/2, Screen.height/2, buttonWidth, buttonHeight),name))
		{
			Application.LoadLevel("Level1");
		}

	}
}
