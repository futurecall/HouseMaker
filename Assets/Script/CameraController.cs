using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	float depth = 0;
	float rotate = 0;
	void Update () {
		if (Input.GetKey ("e")) {
			if (rotate < 1.0) {
				rotate += 0.1f;
			}
		} else if (Input.GetKey ("q")) {
			if (rotate > -1.0) {
				rotate -= 0.1f;
			}
		} else {
			rotate *= 0.1f;
			if (rotate*rotate  < 0.0001) {
				rotate = 0;
			}
		}

		if (Input.GetKey ("x")) {
			//this.transform.Translate (0, 0, -1);
			if (depth > -0.1) {
				depth -= 0.008f;
			}
		} else if (Input.GetKey ("z")) {
			if (depth < 0.1) {
				depth += 0.008f;
			}
			//this.transform.Translate (0, 0, 1);
		} else {
			depth = depth * 0.5f;
			if (depth*depth  < 0.0001) {
				depth = 0;
			}
		}
		this.transform.Translate(( Input.GetAxis ( "Horizontal" ) * 0.1f ),( Input.GetAxis ( "Vertical" ) * 0.1f ),depth);
		this.transform.Rotate (new Vector3(0.0f,rotate,0.0f));
	}
}
