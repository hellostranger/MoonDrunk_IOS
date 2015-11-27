using UnityEngine;
using System.Collections;

public class StaticVars :MonoBehaviour  {

	private static StaticVars instance;
	private static bool soundType = false;
	private AudioSource asc;

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
	public void NarrSound()
	{
		AudioSource asc = gameObject.AddComponent<AudioSource> ();
		asc.clip = Resources.Load ("audios/narration") as AudioClip;
		asc.Play ();
	}

	public void IntroSound()
	{
		AudioSource asc = gameObject.AddComponent<AudioSource> ();
		asc.clip = Resources.Load ("audios/intro_23") as AudioClip;
		asc.Play ();
		/*
		Debug.Log ("SoundOn");
		if (!asc) {
			asc = gameObject.AddComponent<AudioSource> ();
			asc.loop = true;
		}else{
			asc.Stop();
		}
		if ( soundType )
		{
			asc.clip = Resources.Load ("audios/narration") as AudioClip;
		}else{
			asc.clip = Resources.Load ("audios/narration") as AudioClip;
		}
		soundType = !soundType;
		asc.Play ();
		*/
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
