using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public PlayerRotate playerRotate;
	public float playerMoveSpeed;
	//public float rotationSpeed;

	public Vector3 playerDir;

	// Use this for initialization
	void Start () {
		//Vector3 playerDir = Vector3.zero;
	}
	void Update(){
		transform.rotation = playerRotate.playerRotation;

	}
	// Update is called once per frame
	void FixedUpdate (){
			playerDir.x = Input.acceleration.y;
			//playerDir.z = -Input.acceleration.x;			
			//Debug.Log (-Input.acceleration.x);
			playerDir *= Time.deltaTime;
			
			Debug.Log (playerRotate.playerRotation.x);
			//if (playerDir.sqrMagnitude > 1)
			//	playerDir.Normalize();
			rigidbody.AddForce (playerDir * playerMoveSpeed);
			if (Input.GetKey ("a")) {
				//rigidbody.AddRelativeTorque(100 * Time.deltaTime,0,0);
			transform.Rotate (new Vector3(100 * Time.deltaTime,0,0));
			}
			//transform.rotation = playerRotate.transform.rotation;
			//transform.Translate(playerDir * playerMoveSpeed);
	}
}
