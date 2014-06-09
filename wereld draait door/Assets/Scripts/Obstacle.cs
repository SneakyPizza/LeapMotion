using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour 
{ 
	
	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.name == "Player")
		{
			Destroy(col.gameObject);
			Application.LoadLevel("1");
		}

	}

}
