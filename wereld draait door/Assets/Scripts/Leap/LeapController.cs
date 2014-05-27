using UnityEngine;
using System.Collections;
using Leap;

public class LeapController : MonoBehaviour 
{
	private static Controller _leapController = new Controller();
	private static Frame _currentFrame = Frame.Invalid;

	private float _screenToWorldDistance = 10.0f;

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

	void Update () 
	{
		_currentFrame = _leapController.Frame();
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