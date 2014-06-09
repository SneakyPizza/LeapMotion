using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour 
{
	public GUITexture mainTexture;
	public GUITexture playTexture;

	public string gameTitle;

	public float buttonWidth;
	public float buttonHeight;

	public string playName;
	public float playX;
	public float playY;

	public bool scoreButton;
	public string scoreName;
	public float scoreX;
	public float scoreY;

	public string settingsName;
	public float settingsX;
	public float settingsY;

	public string quitName;
	public float quitX;
	public float quitY;

	public bool extraButton1;
	public string button1Name;
	public float button1X;
	public float button1Y;

	public bool extraButton2;
	public string button2Name;
	public float button2X;
	public float button2Y;

	public bool extraButton3;
	public string button3Name;
	public float button3X;
	public float button3Y;

	public bool extraButton4;
	public string button4Name;
	public float button4X;
	public float button4Y;

	void Update(){
	//	playX *= Screen.width;

	}

	void OnGUI()
	{
		if(GUI.Button(new Rect(playX, playY, buttonWidth, buttonHeight),playName))
		{
			Application.LoadLevel("Level1");
		}
	//	mainTexture.pixelInset = new Rect (0,0,Screen.width,Screen.height);
		if(scoreButton){
			if(GUI.Button(new Rect(scoreX, scoreY, buttonWidth, buttonHeight),scoreName))
			{
				Debug.Log("Score");
				//Application.LoadLevel("Score");
			}
		}

		if(GUI.Button(new Rect(settingsX, settingsY, buttonWidth, buttonHeight),settingsName))
		{
			Debug.Log("Settings");
			//Application.LoadLevel("Settings");
		}

		if(GUI.Button(new Rect(quitX, quitY, buttonWidth, buttonHeight),quitName))
	    {
			Application.Quit();
		}
		if(extraButton1){
			if(GUI.Button(new Rect(button1X, button1Y, buttonWidth, buttonHeight),button1Name))
			{
				Debug.Log("button1");
				//Application.LoadLevel("ExtraFunction1");
			}
		}
		if(extraButton2){
			if(GUI.Button(new Rect(button2X, button1Y, buttonWidth, buttonHeight),button2Name))
			{
				Debug.Log("button2");
				//Application.LoadLevel("ExtraFunction2");
			}
		}
		if(extraButton3){
			if(GUI.Button(new Rect(button3X, button3Y, buttonWidth, buttonHeight),button3Name))
			{
				Debug.Log("button3");
				//Application.LoadLevel("ExtraFunction3");
			}
		}
		if(extraButton4){
			if(GUI.Button(new Rect(button4X, button4Y, buttonWidth, buttonHeight),button4Name))
			{
				Debug.Log("button4");
				//Application.LoadLevel("ExtraFunction4");
			}
		}

	}
}
