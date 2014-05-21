using UnityEngine;
using System.Collections;

public class PlayerRotate : MonoBehaviour {
	
	public float rotationSpeed;
	public Quaternion playerRotation;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0, Input.acceleration.x * Time.deltaTime * rotationSpeed, 0));
				//transform.Translate(new Vector3(0,0,Input.acceleration.y * speed * Time.deltaTime));
	
		playerRotation = transform.rotation;
	}
}
