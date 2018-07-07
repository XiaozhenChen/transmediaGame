using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class buttom : MonoBehaviour {

	private Button myButton;



	// Use this for initialization
	void Start () {
		myButton =  GetComponent<Button>();

		Button btn = myButton.GetComponent<Button>();
		btn.onClick.AddListener (TaskOnClick);

	}

	void TaskOnClick(){
	
		Debug.Log ("You have clicked the button!");
	}



}
