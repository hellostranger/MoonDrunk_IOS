using UnityEngine;
using System.Collections;

public class CheckMode : MonoBehaviour {

	public Cardboard cb;
	// Use this for initialization
	void Start () {
		Debug.Log ("StaticVars.GetInstance.SelectScreen : "+StaticVars.GetInstance.SelectScreen);
		//Debug.Log ("cb.VRModeEnabled :"+cb.VRModeEnabled);
		if (StaticVars.GetInstance.SelectScreen != 2) {
			cb.VRModeEnabled = true;
		} else {
			cb.VRModeEnabled = false;
		}
		//Debug.Log ("cb.VRModeEnabled :"+cb.VRModeEnabled);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
