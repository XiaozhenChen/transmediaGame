using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class S1Puppeteer : CutscenePuppeteer {

	private GameObject ChefTony;

	public AudioClip dog;

	// Use this for initialization
	void Start () {
		// get all the objects we'll need for the cutscene 
		ChefTony = GameObject.Find ("Chef Tony");
	}
	
	// Update is called once per frame
	public override void Update () {
		base.Update();

		if(CurrentScene == 3 && timerIsGreaterThan(1)) {
			FadeAndNext(Color.black, 2, "2-01 Limbo", true);
			//nextScene();
			stopTimer();
		}
			
	}

	public override void HandleSceneChange() {
		if(CurrentScene <= 3) {
			ChefTony.GetComponent<PlayerControl>().enabled = false;
		} else {
			ChefTony.GetComponent<PlayerControl>().enabled = true;
		}

		if(CurrentScene == 3) {
			ChefTony.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 1000f);
			playSound(dog);
			startTimer();
		}
	}
}
