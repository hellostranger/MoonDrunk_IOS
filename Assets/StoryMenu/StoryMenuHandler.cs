using UnityEngine;
using System.Collections;

public class StoryMenuHandler : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	public void Menu1Click()
	{
		Debug.Log ("월하독작");
		StaticVars.GetInstance.SelectStory = 1;
		Application.LoadLevel("ScreenMenu");
	}
	public void Menu2Click()
	{
		Debug.Log ("방랑");
		StaticVars.GetInstance.SelectStory = 2;
		Application.LoadLevel("ScreenMenu");
	}
	// Update is called once per frame
	void Update () {

	}
}
