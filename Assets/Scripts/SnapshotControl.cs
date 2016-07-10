using UnityEngine;
using System.Collections;

public class SnapshotControl : MonoBehaviour {

	int count = 0; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (count == 0 && Input.GetKeyDown(KeyCode.S)) {
			Application.CaptureScreenshot("Screenshot.png");
			count = 1;
		}
		else if(count > 0 && Input.GetKeyDown(KeyCode.S)){
			Application.CaptureScreenshot("Screenshot" + count + ".png");
			count++;
		}

	
	}
}
