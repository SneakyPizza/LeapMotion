using UnityEngine;
using System.Collections;
using Leap;

public class LeapController : MonoBehaviour 
{
	public Camera _mainCam;
	
	private static Controller _leapController = new Controller();
	private static Frame _currentFrame = Frame.Invalid;

	private float _screenToWorldDistance = 10.0f;


	//public Vector3 handScreenPosition = _leapManager.leapPositionToScreen(_leapManager.frontmostHand().palmPosition);

	public Controller leapController
	{
		get
		{ 
			return _leapController;
		}
	}

	public Frame currentFrame
	{
		get 
		{
			return _currentFrame; 
		}
	}

	/*public static bool isForwardRelativeToHand(Pointable item, Hand hand)
	{
		return Vector3.Dot((item.TipPosition.ToUnity() - hand.PalmPosition.ToUnity()).normalized, hand.Direction.ToUnity()) > _forwardFingerContraint;
	}*/


	void Start () 
	{
		if(_mainCam == null)
		{
			_mainCam = (GameObject.FindGameObjectWithTag("MainCamera") as GameObject).GetComponent(typeof(Camera)) as Camera;
		}
		//Debug.Log(_mainCam);
	}

	void Update () 
	{
		_currentFrame = _leapController.Frame();
		
		//Hand primeHand = frontmostHand();
	}

	public Hand frontmostHand()
	{
		float minZ = float.MaxValue;
		Hand forwardHand = Hand.Invalid;
		
		foreach(Hand hand in _currentFrame.Hands)
		{
			if(hand.PalmPosition.z < minZ)
			{
				minZ = hand.PalmPosition.z;
				forwardHand = hand;
			}
		}
		
		return forwardHand;
	}
}