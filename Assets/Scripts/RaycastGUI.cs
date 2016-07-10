using UnityEngine;
using System.Collections;

public class RaycastGUI : MonoBehaviour {
    public float seeDistance = 10.0f;
    Light lastLigh = null;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space) && lastLigh!=null)
        {
            MoveRaycast.MoveObject(lastLigh.gameObject);
        }
	
	}

    void FixedUpdate()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        RaycastHit hit;

        if (Physics.Raycast(transform.position, fwd, out hit, seeDistance))
        {
            if (lastLigh != null)
            {
                lastLigh.enabled = false;
            }
            Debug.Log("Widzę: " + hit.collider.gameObject.name);
            if (hit.collider.gameObject.GetComponent<Light>() != null)
            {

                lastLigh = hit.collider.gameObject.GetComponent<Light>();
                lastLigh.enabled = true;
            }
          
        }
    }
}
