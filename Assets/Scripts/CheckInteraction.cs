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
		stateMoon = false;
		stateShadow = false;
		stateCup = false;


	}
	
	// Update is called once per frame
	void Update () {
		if (mpc.m_CurrentState == MediaPlayerCtrl.MEDIAPLAYER_STATE.PLAYING) {
			mpc.Pause();
		}
		if (stateMoon && stateShadow && stateCup) 
		{
			//Animation anim = GetComponent<Animation>();
			if ( !anim.isPlaying )
			{
				Debug.Log ("ani complete");
				stateMoon = false;
				stateShadow = false;
				stateCup = false;
				//mpc.Play();
				Application.LoadLevel("Story3");
			}
		}
	}
}
