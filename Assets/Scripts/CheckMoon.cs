using UnityEngine;
using System.Collections;

public class CheckMoon : MonoBehaviour {

	public Animator ani;
	private bool timer;
	public float delay = 2;
	private float stTime;
	private bool state = false;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (timer) {
			if ( delay <= Time.time - stTime && stTime > 0)
			{
				ani.Play("Moon_move");
				state = true;
				CheckInteraction.stateMoon = true;

				SphereCollider sc = GetComponent<SphereCollider>();
				GameObject.Destroy(sc);
			}else{

			}
		}
	}
	
	public void GazeStart(){
		Debug.Log ("GazeStart");
		if (!state) {
			ani.Play ("Moon_shake");
			timer = true;
			stTime = Time.time;
		}
	}
	public void GazeEnd(){
		Debug.Log ("GazeEnd");
		//ani.Stop ();
		if (!state) {
			ani.Play ("Moon_idle");
			timer = false;
		}
	}
}
