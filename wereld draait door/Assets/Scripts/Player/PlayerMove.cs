using UnityEngine;
using System.Collections;
using Leap;

public class PlayerMove : MonoBehaviour {

	public PlayerRotate playerRotate;
	public float playerMoveSpeed;
	public Vector3 playerDir;

	void Update()
	{
		transform.rotation = playerRotate.playerRotation;
	}

	void FixedUpdate ()
	{
			playerDir *= Time.deltaTime;

			// the bigger the player, speed up
			//rigidbody.AddForce ( * playerMoveSpeed);
	}
}
