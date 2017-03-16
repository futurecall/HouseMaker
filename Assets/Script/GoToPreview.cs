using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToPreview : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ButtonPush() {
		Debug.Log("Now scene is " + Application.loadedLevelName);
		Application.LoadLevel("Preview");
	}
}
