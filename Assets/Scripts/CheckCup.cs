using UnityEngine;
using System.Collections;

public class CheckCup : MonoBehaviour {
	public MediaPlayerCtrl mpc;
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
			if ( delay <= Time.time - stTime && stTime > 0 && !state)
			{
				state = true;
				//Material m = Resources.Load("Materials/InSideShpereInteraction2", typeof(Material)) as Material;
				//sphere.GetComponent<Renderer>().material = m;
				Animation anim = GetComponent<Animation>();
				anim.Play("C4D Animation Take");
				CheckInteraction.stateCup = true;

				BoxCollider bc = GetComponent<BoxCollider>();
				GameObject.Destroy(bc);
			}else{
				
			}
		}
		/*
		if (state) {
			Animation anim = GetComponent<Animation>();
			if ( !anim.isPlaying )
			{
				Debug.Log ("ani complete");
				//mpc.Play();
				Application.LoadLevel("Story3");
			}
		}
		*/
	}
	
	public void GazeStart(){
		if (!state) {
			timer = true;
			stTime = Time.time;
		}
	}
	public void GazeEnd(){
		if (!state) {
			timer = false;
		}
	}
}
