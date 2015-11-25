using UnityEngine;
using System.Collections;

public class ScreenMenuHandler : MonoBehaviour {
	
	public void Menu1Click()
	{
		Debug.Log ("VR모드");
		StaticVars.GetInstance.SelectScreen = 1;
		Application.LoadLevel("Story1");
	}
	public void Menu2Click()
	{
		Debug.Log ("일반모드");
		StaticVars.GetInstance.SelectScreen = 2;
		Application.LoadLevel("Story1");
	}
	// Use this for initialization
	void Start () {
		
	}
	// Update is called once per frame
	void Update () {
		//Debug.Log ("StaticVars.GetInstance.SelectStory : "+StaticVars.GetInstance.SelectStory);
		//Debug.Log ("StaticVars.GetInstance.SelectScreen : "+StaticVars.GetInstance.SelectScreen);
	}
}
