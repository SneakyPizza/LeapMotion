using UnityEngine;
using System.Collections;
using Leap;

public class LeapMovement : MonoBehaviour 
{
	//public GameObject[] colliders;
	
	//private LeapManager leapManager;


	private LeapController leapController;
	
	void Start () 
	{
		leapController = (GameObject.Find("LeapManager")as GameObject).GetComponent(typeof(LeapController)) as LeapController;
	}
	
	void Update () 
	{
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
}
