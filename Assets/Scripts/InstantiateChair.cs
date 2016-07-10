using UnityEngine;
using System.Collections;

public class InstantiateChair : MonoBehaviour {

	GameObject chair;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		GameObject chair =	Instantiate(Resources.Load("example_chair"), new Vector3(-2, 1, 0), Quaternion.identity) as GameObject;
		chair.transform.Rotate (Vector3.right, 270);
	}
}