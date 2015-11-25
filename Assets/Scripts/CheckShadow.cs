using UnityEngine;
using System.Collections;

public class CheckShadow : MonoBehaviour {
	private bool timer;
	public float delay = 2;
	private float stTime;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (timer) {
			if ( delay <= Time.time - stTime && stTime > 0)
			{
				//Material m = Resources.Load("Materials/InSideShpereInteraction2", typeof(Material)) as Material;
				//sphere.GetComponent<Renderer>().material = m;
				Animation anim = GetComponent<Animation>();
				anim.wrapMode = WrapMode.Loop;
				anim.Play("C4D Animation Take");
				CheckInteraction.stateShadow = true;

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
