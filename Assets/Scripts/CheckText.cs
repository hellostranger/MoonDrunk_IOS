using UnityEngine;
using System.Collections;

public class CheckText : MonoBehaviour {
	public Animation animMoon;
	public Animation animShadow;
	public GameObject Shadow;
	public GameObject cam;

	private bool timer;
	public float delay = 2;
	private float stTime;
	private bool state = false;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		//transform.LookAt(transform.position + cam.transform.rotation * Vector3.forward, cam.transform.rotation * Vector3.up);
		//transform.LookAt(cam.transform.position,-Vector3.up);

		if (timer && !state) {
			if ( delay <= Time.time - stTime && stTime > 0)
			{
				Animator aniText = gameObject.GetComponent<Animator>();
				aniText.Play ("TextFadeOut");
				//animShadow.wrapMode = WrapMode.Loop;
				Shadow.SetActive (true);
				animShadow.Play("shadow_intro");
				animShadow.PlayQueued("shadow_dance");

				animMoon.Play("moon_move");

				MeshCollider mc = GetComponent<MeshCollider>();
				GameObject.Destroy(mc);

				state = true;
				CheckInteraction.stateShadow = true;
				CheckInteraction.stateMoon = true;
			}else{
				
			}
		}
	}

	public void GazeStart(){
		timer = true;
		stTime = Time.time;
	}
	public void GazeEnd(){
		timer = false;
	}
}
