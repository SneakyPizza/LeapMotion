using UnityEngine;
using System.Collections;

public class Hitpoints : MonoBehaviour 
{
	public int hitpoints;
	public int damage;
	
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



	}
}
