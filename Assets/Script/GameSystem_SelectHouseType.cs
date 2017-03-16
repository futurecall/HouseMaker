using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSystem_SelectHouseType : MonoBehaviour {
	public Canvas canvas;
	public static bool selectsize_flg;	//True:サイズ選択中
	public static float input_x;		//入力されたhouseのXsize
	public static float input_y;		//入力されたhouseのYsize
	public Slider Slider_x;		
	public Slider Slider_y;
	public Text Text_inputXsize;
	public Text Text_inputYsize;
	// Use this for initialization
	void Start () {
		canvas.enabled = false;
		selectsize_flg = false;
	}
	
	// Update is called once per frame
	void Update () {
		Text_inputXsize.text = Slider_x.value.ToString();
		Text_inputYsize.text = Slider_y.value.ToString(); 
	}

	public void GoButtonPush() {
		input_x = float.Parse(Text_inputXsize.text);
		input_y = float.Parse(Text_inputYsize.text);
		Debug.Log ("Now scene is " + Application.loadedLevelName);
		Application.LoadLevel ("Design");
	}

	public void BackButtonPush() {
		canvas.enabled = false;
		selectsize_flg = false;
	}

	public void DoneButtonPush(){
		if (!selectsize_flg) {
			canvas.enabled = true;
			selectsize_flg = true;
		}
	}

	// getter
	public static bool getselect_size_flg(){
		return selectsize_flg;
	}
	public static float get_input_x(){
		return input_x;
	}
	public static float get_input_y(){
		return input_y;
	}
	//setter
	public static void setselect_size_flg(bool a){
		selectsize_flg = a;
	}
}
