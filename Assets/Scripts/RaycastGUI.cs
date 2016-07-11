using UnityEngine;
using System.Collections;

public class RaycastGUI : MonoBehaviour {
    public float seeDistance = 10.0f;
    Light lastLigh = null;
    GameObject currTarget = null;
    GameObject lastDrag = null;
    //czy jest cos przeciagane?
    bool doLookUp = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space) && lastLigh!=null)
        {
            lastLigh.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            MoveRaycast.MoveObject(lastLigh.gameObject);
            lastDrag = lastLigh.gameObject;
            doLookUp = false;

        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            lastDrag.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            doLookUp = true;
        }
	
	}

    void FixedUpdate()
    {
        if (doLookUp == true)
        {
            Vector3 fwd = transform.TransformDirection(Vector3.forward);
            RaycastHit hit;

            if (Physics.Raycast(transform.position, fwd, out hit, seeDistance))
            {
                currTarget = transform.gameObject;
                if (lastLigh != null && lastLigh != currTarget.GetComponent<Light>())
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
}
