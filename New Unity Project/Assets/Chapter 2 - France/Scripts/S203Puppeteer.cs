using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class S203Puppeteer : CutscenePuppeteer {

	public AudioClip evilMusic;
	public AudioClip hangupSound;
	private MusicPlayer mp;



	public AudioClip m1;

	public AudioClip m2;

	public AudioClip m3;


	// Use this for initialization
	void Start () {
		mp = GameObject.Find("BGM").GetComponent<MusicPlayer>();

	}
	
	// Update is called once per frame
	public void FixedUpdate () {

//		if(CurrentScene == 3) {
//			StartCoroutine(FadeAndNext(Color.white, 0, "2-02 France 1"));
//			nextScene();
//		}
//		
	}

	public override void HandleSceneChange() {

	
		if(CurrentScene ==1) {
			mp.PlayMusic(m1, true);

		} else if(CurrentScene ==3) {
			mp.PlayMusic(m1, false);
			//playSound(m2);
		} 
		else if(CurrentScene ==4) {
			//mp.PlayMusic(m1, false);
			playSound(m2);
		} 
		
		else if( CurrentScene ==9) {
			
			mp.PlayMusic(m3, true);

		}


		else if (CurrentScene ==28) {
			mp.PlayMusic(m3, false);
			//playSound(m3);
			FadeAndNext(Color.black, 2, "2-04 France 2", true);
		}

	}


}
