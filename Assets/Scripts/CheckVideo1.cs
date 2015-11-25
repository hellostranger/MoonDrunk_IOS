using UnityEngine;
using System.Collections;

public class CheckVideo1 : MonoBehaviour {
	public MediaPlayerCtrl mpc;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (mpc.m_CurrentState == MediaPlayerCtrl.MEDIAPLAYER_STATE.END) 
		{
			//Application.LoadLevel("Story3");
		}
	}
}
