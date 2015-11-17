using UnityEngine;
using System.Collections;

public class checkStart : MonoBehaviour {
	public GameObject go;
	public MediaPlayerCtrl mpc;
	//public Animator ani;
	private bool timer;
	public float delay = 2;
	private float stTime;
	public Material redPointer;
	public Material blackPointer;
	public UnityEngine.UI.Image progress;
	public float per;
	// Use this for initialization
	void Start () {
		progress.fillAmount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (timer) {
			if ( delay <= Time.time - stTime && stTime > 0)
			{
				GameObject.Destroy(go);
				GameObject.Destroy(GameObject.Find("Pointer"));
				//ani.Play("move");
				mpc.Play();
				Debug.Log ("Play");
			}else{
				per = (Time.time - stTime)/delay;
				progress.fillAmount = per;
			}
		}
	}

	public void ChangeColor1(){
		Debug.Log ("true");
		GameObject marker = GameObject.Find("Marker");
		marker.GetComponent<Renderer>().material = redPointer;
		timer = true;
		stTime = Time.time;
	}
	public void ChangeColor2(){
		progress.fillAmount = 0;
		Debug.Log ("false");
		GameObject marker = GameObject.Find ("Marker");
		marker.GetComponent<Renderer>().material = blackPointer;
		timer = false;
	}
}
