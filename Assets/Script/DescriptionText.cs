using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//この宣言が必要

public class DescriptionText : MonoBehaviour {

	static Text myText;
	public static int No;

	enum HouseModel : int
	{
		FirstHouse, SecondHouse, ThirdHouse, ForthHouse
	}
	// Use this for initialization
	void Start () {
		myText = GetComponentInChildren<Text>();//UIのテキストの取得の仕方
		myText.text = "代替テキストC";//テキストの変更
		ChangeHouseModel();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static void SetNo(int a){
		No += a;
		ChangeHouseModel ();
	}

	static void ChangeHouseModel(){
		if (No == 0) {
			myText.text = "This is FirstHouse";
		}
		else if (No == 1){
			myText.text = "This is SecondHouse";
		}
	}

}
