using UnityEngine;
using System.Collections;

public class PlayerRotate : MonoBehaviour 
{
	public float rotationSpeed;
	public Quaternion playerRotation;


	void Update () 
	{
		transform.Rotate (new Vector3 (0, Input.acceleration.x * Time.deltaTime * rotationSpeed, 0));
	
		playerRotation = transform.rotation;
	}
}
