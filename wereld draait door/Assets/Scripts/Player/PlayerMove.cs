using UnityEngine;
using System.Collections;
using Leap;

public class PlayerMove : MonoBehaviour 
{
	private Vector3 mouseInput;
	private Vector3 currentPosition;
	private float mouseSpeed = 50f;

	private float timer = 0.5f;

	public GameObject Player;


	void Update()
	{
		mouseInput = new Vector3(-Input.GetAxis("Mouse X"),0,0);
		currentPosition += mouseInput;
		transform.position += currentPosition / mouseSpeed;

		timer -= Time.deltaTime;

		if(timer <= 0)
		{
			Player.rigidbody.AddForce(Vector3.forward * 50);
			Debug.Log("sanicSpeedUp");
			timer += 0.5f;
		}
	}
}
