using UnityEngine;
using System.Collections;

public class BackButton : MonoBehaviour 
{
	public Texture backButton;

	void OnGUI()
	{
		if(GUI.Button(new Rect(Screen.width /2 - 132.5f ,300 ,buttonWidth,buttonHeight),"Play!"))
		{
			Debug.Log("play!");
			Application.LoadLevel(1);
		}
	}


}
