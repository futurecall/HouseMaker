using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class GameSystem : MonoBehaviour {
	// キャンバス
	public Canvas Canvas;
	// 壁
	public GameObject WidthWall;
	public GameObject HeightWall;
	public GameObject ParentWall;

	public float x = 1;
	public float y = 1;
	// Use this for initialization
	void Start () {
		bool[,] HeightWall_flg = GameSystem_Design.getHeightWallflg();
		bool[,] WidthwWall_flg = GameSystem_Design.getWidthWallflg();
		int width = GameSystem_Design.getWidth();
		int height = GameSystem_Design.getHeight ();
		Canvas.enabled = false;

		// HeightWall
		for (int i= -height/2; i < height/2+1;i++) {
			for (int j = -width / 2; j < width/2; j++) {
				if (HeightWall_flg[i+height/2,j+width/2]) {
					GameObject obj = Instantiate(HeightWall, new Vector3(i*x,0, j*y+0.5f), HeightWall.transform.rotation);
					obj.name = "HeightWall_" + (i + height / 2) + "-" + (j + width / 2);
					obj.transform.parent = ParentWall.transform;
				}
			}
		}
		// WidthWall
		for (int i = -height / 2; i < height / 2; i++) {
			for (int j = -width / 2; j < width / 2 + 1; j++) {
				if (WidthwWall_flg[i+height/2,j+width/2]) {
					GameObject obj = Instantiate(WidthWall, new Vector3(i*x+0.5f,0, j*y), WidthWall.transform.rotation);
					obj.name = "WidthWall_" + (i+height/2)+"-" + (j+width/2);
					obj.transform.parent = ParentWall.transform;
				}
			}
		}
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("p")) {
			Canvas.enabled = !Canvas.enabled;
		}
	}

	//functions
	public void PushGoToHomeButton(){
		Debug.Log("Now scene is " + Application.loadedLevelName);
		Application.LoadLevel("Home");
	}
	public void PushGoToSelectHouseButton(){
		Debug.Log("Now scene is " + Application.loadedLevelName);
		Application.LoadLevel("SelectHouseType");
	}
	public void PushGoToDesignButton(){
		Debug.Log ("Now scene is " + Application.loadedLevelName);
		Application.LoadLevel ("Design");
	}
}

