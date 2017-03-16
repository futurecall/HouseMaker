using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem_Design: MonoBehaviour {
	// 
	// キャンバス
	public Canvas Canvas;
	// 壁の配列
	public static  bool[,] WidthWall_flg = new bool[12, 13];
	public static  bool[,] HeightWall_flg = new bool[13, 12];
	// rayが届く範囲
	public float distance = 10000f;
	// 生成したいPrefab
	public GameObject HeightWall;
	public GameObject WidthWall;
	public GameObject Wall;		// ParentWall
	// Use this for initialization
	public static int height = 12;
	public static int width = 12;

	public float x = 1;
	public float y = 1;
	void Start () {
		
		// 縦の壁
		for (int i= -width/2; i < width/2+1;i++) {
			for (int j = -height / 2; j < height/2; j++) {
				GameObject obj = Instantiate(HeightWall, new Vector3(i*x, j*y+0.5f, 0), HeightWall.transform.rotation);
				obj.name = "HeightWall_" + (i + height / 2) + "-" + (j + width / 2);
				obj.transform.parent = Wall.transform;
			}
		}
		// 横の壁
		for (int i= -width/2; i < width/2;i++) {
			for (int j = -height / 2; j < height/2+1; j++) {
				GameObject obj = Instantiate(WidthWall, new Vector3(i*x+0.5f, j*y, 0), WidthWall.transform.rotation);
				obj.name = "WidthWall_" + (i+height/2)+"-" + (j+width/2);
				obj.transform.parent = Wall.transform;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
//		if (Input.GetKeyDown ("p")) {
//			Canvas.enabled = !Canvas.enabled;
//		}

		if (Input.GetMouseButtonDown(0)) {
			// クリックしたスクリーン座標をrayに変換
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			// Rayの当たったオブジェクトの情報を格納する
			RaycastHit hit = new RaycastHit();
			// オブジェクトにrayが当たった時
			if (Physics.Raycast(ray, out hit, distance)) {
				string objectName = hit.collider.gameObject.name;
				// HeightWall
				for (int i= -height/2; i < height/2+1;i++) {
					for (int j = -width / 2; j < width/2; j++) {
						if (objectName == "HeightWall_" + (i + height / 2) + "-" + (j + width / 2)) {
							GameObject gmobj = hit.collider.gameObject;
							HeightWall_flg [i + height / 2,j + width / 2] = !(HeightWall_flg [i + height / 2,j + width / 2]);
							foreach(Renderer targetRenderer in gmobj.GetComponents<Renderer>()){
								foreach(Material material in targetRenderer.materials){
									if(HeightWall_flg [i + height / 2,j + width / 2])
										material.color = new Color(1.0f, 0.0f, 0.0f, 1f);
									else
										material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
								}
							}
							Debug.Log(objectName + "=" + HeightWall_flg [i + height / 2,j + width / 2]);
						}
					}
				}
				// WidthWall
				for (int i = -height / 2; i < height / 2; i++) {
					for (int j = -width / 2; j < width / 2 + 1; j++) {
						if (objectName == "WidthWall_" + (i+height/2)+"-" + (j+width/2)) {
							GameObject gmobj = hit.collider.gameObject;
							WidthWall_flg [i+height/2,j+width/2] = !(WidthWall_flg [i+height/2,j+width/2]);
							foreach(Renderer targetRenderer in gmobj.GetComponents<Renderer>()){
								foreach(Material material in targetRenderer.materials){
									if(WidthWall_flg [i + height / 2,j + width / 2])
										material.color = new Color(1.0f, 0.0f, 0.0f, 1f);
									else
										material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
								}
							}
							Debug.Log(objectName + "=" + WidthWall_flg [i + height / 2,j + width / 2]);
						}
					}
				}
			}
		}
	}


	// functions
	public void PushPreviewButton(){
		Debug.Log("Now scene is " + Application.loadedLevelName);
		Application.LoadLevel("Preview");
	}

	// getter
	public static bool[,] getWidthWallflg() {
		return WidthWall_flg;
	}
	public static bool[,] getHeightWallflg() {
		return HeightWall_flg;
	}
	public static int getWidth(){
		return width;
	}
	public static int getHeight(){
		return height;
	}
}
