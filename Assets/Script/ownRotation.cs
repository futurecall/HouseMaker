﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ownRotation : MonoBehaviour {
	public float rotate;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate (new Vector3(0.0f,rotate,0.0f));
	}
}
