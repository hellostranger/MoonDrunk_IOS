using UnityEngine;
using System.Collections;

public class CheckInteraction : MonoBehaviour {
	public MediaPlayerCtrl mpc;
	public Animation anim;

	public static bool stateMoon = false;
	public static bool stateShadow = false;
	public static bool stateCup = false;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (mpc.m_CurrentState == MediaPlayerCtrl.MEDIAPLAYER_STATE.PLAYING) {
			mpc.Pause ();
		}
		if (stateMoon && stateShadow && stateCup) 
		{
			//Animation anim = GetComponent<Animation>();
			if ( !anim.isPlaying )
			{
				stateMoon = false;
				stateShadow = false;
				stateCup = false;
				Debug.Log ("ani complete");
				//mpc.Play();
				Application.LoadLevel("Story3");

			}
		}
	}
}
