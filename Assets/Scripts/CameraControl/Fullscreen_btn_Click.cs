using UnityEngine;
using System.Collections;

public class Fullscreen_btn_Click : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.F)) {
			if (Screen.fullScreen == false) {
				Screen.fullScreen = true;
			} else {
				Screen.fullScreen = false;
			}
		}
	
	}

}
