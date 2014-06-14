using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	private float score;

	// Use this for initialization
	void Start () {
		score = Constants.MAX_SCORE;
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	public float getScore()
	{
		return score;
	}
	
	void OnCollisionEnter(Collision col){
		if(col.gameObject.tag == "Wall")
		{
			Debug.Log("Score -= 200!");
			score -= 200;
		}
	}
}
