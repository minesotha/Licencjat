using UnityEngine;
using System.Collections;

public class VelocityDragMovement : MonoBehaviour {

	public Vector3 gameObjectSreenPoint;
	public Vector3 mousePreviousLocation;
	public Vector3 mouseCurLocation;

	void OnMouseDown()
	{
		//This grabs the position of the object in the world and turns it into the position on the screen
		gameObjectSreenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
		//Sets the mouse pointers vector3
		mousePreviousLocation = new Vector3(Input.mousePosition.x, gameObjectSreenPoint.z, Input.mousePosition.y);
		GameObject costam = new GameObject ();

	}
	
	public Vector3 force;
	public Vector3 objectCurrentPosition;
	public Vector3 objectTargetPosition;
	public float topSpeed = 10;
	void OnMouseDrag()
	{
		mouseCurLocation = new Vector3(Input.mousePosition.x, gameObjectSreenPoint.z, Input.mousePosition.y);
		force = mouseCurLocation - mousePreviousLocation;//Changes the force to be applied
		mousePreviousLocation = mouseCurLocation;
	}
	
	public void OnMouseUp()
	{
		//Makes sure there isn't a ludicrous speed
		if (GetComponent<Rigidbody>().velocity.magnitude > topSpeed)
			force = GetComponent<Rigidbody>().velocity.normalized * topSpeed;
	}
	
	public void FixedUpdate()
	{
		GetComponent<Rigidbody>().velocity = force;
	}
}