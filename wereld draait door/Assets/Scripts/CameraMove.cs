using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {
	//public PlayerMove playerMove;
	public GameObject player;

	private Vector3 offset;
	// Use this for initialization
	void Start () {
		offset = transform.position;
	}
	void LateUpdate () {
		transform.position = player.transform.position + offset;

		//Debug.Log (transform);
		//transform.LookAt (playerMove.transform);
		//transform.position = new Vector3(playerMove.transform.position.x - 6,playerMove.transform.position.y + 3, playerMove.transform.position.z);

	}
	void FixedUpdate(){

		//rigidbody.AddForce (playerMove.playerDir * playerMove.playerMoveSpeed / 2);
	}
}
