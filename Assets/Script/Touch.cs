using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour {
	// rayが届く範囲
	public float distance = 10000f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
//		// 左クリックを取得
//		if (Input.GetMouseButtonDown(0)) {
//			// クリックしたスクリーン座標をrayに変換
//			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//			// Rayの当たったオブジェクトの情報を格納する
//			RaycastHit hit = new RaycastHit();
//			// オブジェクトにrayが当たった時
//			if (Physics.Raycast(ray, out hit, distance)) {
//				// rayが当たったオブジェクトの名前を取得
//				string objectName = hit.collider.gameObject.name;
//				Debug.Log(objectName);
//			}
//		}
	}
}
