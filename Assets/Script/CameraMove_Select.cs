using System.Collections;
// using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//この宣言が必要

public class CameraMove_Select : MonoBehaviour {
	public GameObject SelectCam;

	public GameObject[] right;
	public GameObject[] left;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Camera cam = SelectCam.GetComponent (typeof(Camera)) as Camera;

		Vector3 mousePos = cam.ScreenToWorldPoint (Input.mousePosition);
		Collider2D col = Physics2D.OverlapPoint (mousePos);

		if (Input.GetMouseButtonDown (0)) {
			if(!GameSystem_SelectHouseType.getselect_size_flg()){
				//右に移動
				foreach (GameObject Right in right) {
					if (col == Right.GetComponent (typeof(Collider2D)) as Collider2D) {
						SelectCam.transform.position = new Vector3 (SelectCam.transform.position.x + 50, 0, -10);
						DescriptionText.SetNo (+1);
					}
				}
				foreach (GameObject Left in left) {
					if (col == Left.GetComponent (typeof(Collider2D)) as Collider2D) {
						SelectCam.transform.position = new Vector3 (SelectCam.transform.position.x - 50, 0, -10);
						DescriptionText.SetNo (-1);
					}
				}
			}
		}
	}
}
