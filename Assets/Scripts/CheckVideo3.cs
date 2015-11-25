using UnityEngine;
using System.Collections;

public class CheckVideo3 : MonoBehaviour {
	public MediaPlayerCtrl mpc;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (mpc.m_CurrentState == MediaPlayerCtrl.MEDIAPLAYER_STATE.END) 
		{
			Application.LoadLevel("Story1");
		}
		//Debug.Log(this.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName ("complete"));
		/*
		if (this.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName ("complete")) 
		{
			if ( reload )
			{
				Application.LoadLevel("story1_scene2");
			}else{
				reload = true;
			}
		}
		*/
	}
}
