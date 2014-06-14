using UnityEngine;
using System.Collections;

public class Hitpoints : MonoBehaviour 
{
	public int hitpoints;

	public AudioClip hit;
	
	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag == "Wall")
		{
			hitpoints -= 10;
		}

		if(col.gameObject.tag == "Obstacle")
		{
			hitpoints -= 20;
		}

		if (hitpoints <= 0)
		{
			Destroy(gameObject);
		}

		if (col.gameObject.tag == "Blockade")
		{
			audio.PlayOneShot(hit,10f);
		}
	}
}
