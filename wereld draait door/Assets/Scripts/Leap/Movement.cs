using UnityEngine;
using System.Collections;
using Leap;

public class Movement : MonoBehaviour 
{
	private LeapController leapController;

	public Vector3 mouseInput;
	public Vector3 currentPosition;

	public float mouseSpeed;

	public void  LeapControls()
	{
		leapController = (GameObject.Find("LeapManager")as GameObject).GetComponent(typeof(LeapController)) as LeapController;
		Hand primeHand = leapController.frontmostHand();
		
		if(primeHand.IsValid)
		{
			gameObject.transform.position = primeHand.PalmPosition.ToUnityTranslated();
			
			if(gameObject.renderer.enabled != true) 
			{ 
				gameObject.renderer.enabled = true; 
			}
		}
	}

	public void MouseControls()
	{
		mouseInput = new Vector3(0,0,-Input.GetAxis("Mouse X"));
		currentPosition += mouseInput;
		transform.position += currentPosition / mouseSpeed;
	}
}