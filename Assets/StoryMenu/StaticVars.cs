using UnityEngine;
using System.Collections;

public class StaticVars :MonoBehaviour  {

	private static StaticVars instance;

	public static StaticVars GetInstance
	{
		get
		{
			if ( instance == null )
			{
				instance = new GameObject("StaticVars").AddComponent<StaticVars>();
			}

			return instance;
		}
	}
	public void OnApplicationQuit()
	{
		instance = null;
	}
	void Start()
	{
		instance = this;
		DontDestroyOnLoad (this);
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log ("selectedStroy :" + selectedStroy);
	}


	private int selectedStroy;
	private int selectedScreen;
	
	public int SelectStory
	{
		set{ selectedStroy = value; } 
		get { return selectedStroy;		}
	}
	public int SelectScreen
	{
		set{ selectedScreen = value; } 
		get { return selectedScreen;		}
	}
}
