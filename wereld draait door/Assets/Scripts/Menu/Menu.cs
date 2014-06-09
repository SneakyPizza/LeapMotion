using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour 
{
	public GUITexture mainTex;
	public GUITexture pushedTex;

	public float 	buttonWidth;
	public float 	buttonHeight;

	public string	leapPlay;
	public float 	leapPlayX;
	public float 	leapplayY;

	public string 	mousePlay;
	public float	mousePlayX;
	public float 	mousePlayY;

	public string 	quitButton;
	public float	quitButtonX;
	public float	quitButtonY;


	void OnGui()
	{
		if(GUI.Button(new Rect(leapPlayX, leapplayY, buttonWidth, buttonHeight),leapPlay))
		{
			Application.LoadLevel("Level1");
		}

		if(GUI.Button(new Rect(mousePlayX, mousePlayY, buttonWidth, buttonHeight),mousePlay))
		{
			Application.LoadLevel("Level1");
		}

		if(GUI.Button(new Rect(quitButtonX, quitButtonY, buttonWidth, buttonHeight),quitButton))
		{
			Application.Quit();
		}

	}

}
