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
		Debug.Log ("start");
		instance = this;
		DontDestroyOnLoad (this);
	}
	// Update is called once per frame
	void Update () {
		//Debug.Log ("selectedStroy :" + selectedStroy);
	}

	public void SoundOn()
	{
		if (!soundState) {
			AudioSource asc = gameObject.AddComponent<AudioSource> ();
			asc.loop = true;
			asc.clip = Resources.Load ("fusionOST") as AudioClip;
			asc.Play ();
			soundState = true;
		}
	}

	private bool soundState = false;
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
