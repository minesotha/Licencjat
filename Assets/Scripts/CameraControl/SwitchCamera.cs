using UnityEngine;
using System.Collections;



public class SwitchCamera : MonoBehaviour {

	public Camera camera;
	public Camera camera2;

	void Start() {
		camera.enabled = true;
		camera2.enabled = false;
	}
	
	void Update() {
		//Exchanges the cameras state each time (enable disable toggle)
		if (Input.GetKeyUp(KeyCode.C)) {
			camera.enabled = !camera.enabled;
			camera2.enabled = !camera2.enabled;
		}
	}
}
