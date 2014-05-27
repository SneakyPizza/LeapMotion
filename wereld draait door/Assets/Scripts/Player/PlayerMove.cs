using UnityEngine;
using System.Collections;
using Leap;

public class PlayerMove : MonoBehaviour {



	void Update()
	{

	}

	void FixedUpdate ()
	{
		if (Input.GetKey(KeyCode.A)) {
			rigidbody.AddForce(1*Time.deltaTime,0,0);
		}		
			
			// the bigger the player, speed up
			//rigidbody.AddForce ( * playerMoveSpeed);
	}
}
