using UnityEngine;
using System.Collections;
using Leap;

public class PlayerMove : MonoBehaviour 
{

	public Vector3 mouseInput;
	public Vector3 currentPosition;
	public float mouseSpeed;

	void Update()
	{
		mouseInput = new Vector3(0,0,-Input.GetAxis("Mouse X"));
		currentPosition += mouseInput;
		transform.position += currentPosition / mouseSpeed; 
	}

	void FixedUpdate ()
	{
		if (Input.GetKey(KeyCode.A)) 
		{
			rigidbody.AddForce(0,0,20*Time.deltaTime);
			Debug.Log("a");
		}		

			
			// the bigger the player, speed up
			//rigidbody.AddForce ( * playerMoveSpeed);
	}
}
