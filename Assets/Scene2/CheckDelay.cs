using UnityEngine;
using System.Collections;

public class CheckDelay : MonoBehaviour {
	private float delay;
	private float stTime;
	// Use this for initialization
	void Start () {
		delay = 20.0f;
		stTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		float curTime = Time.time;
		if (delay < curTime - stTime) {
			Debug.Log("10");
			Application.LoadLevel("Story1");
		}
	}
}
