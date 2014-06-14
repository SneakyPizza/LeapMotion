using UnityEngine;
using System.Collections;
public class Timer : MonoBehaviour {
	
	private float secElapsed;
	// Use this for initialization
	void Start () {
		secElapsed = 0;
	}
	
	// Update is called once per frame
	void Update () {
		secElapsed += Time.deltaTime;
	}

	public float getSecElapsed()
	{
		return secElapsed;
	}
}
