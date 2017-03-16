using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystemHome : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PushGoToSelectHouseTypeButton(){
		Debug.Log("Now scene is " + Application.loadedLevelName);
		Application.LoadLevel("SelectHouseType");
	}
}
