using UnityEngine;
using System.Collections;

public class GUImanager : MonoBehaviour {
    bool isColliding=false;
    Quaternion lastRotation = new Quaternion();
    public bool isStarting = true;
    public GameObject parentObject;
    float sizeX = 0;
    float sizeY = 0;

    // Update is called once per frame
    void Start()
    {
        this.gameObject.SetActive(false);
    }
	void Update () {
        if (this.isActiveAndEnabled)
        {
            if (isColliding==false)
            {
                lastRotation =  transform.rotation;
                transform.LookAt(Camera.main.transform);
            }
            else
            {
                transform.rotation = lastRotation;
            }

        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.Equals(parentObject))
        {
            Debug.Log("self trigger enter");
            isColliding = true;
            sizeX= parentObject.GetComponent<Renderer>().bounds.size.x/2 + 2;
            sizeY = parentObject.GetComponent<Renderer>().bounds.size.y/2 + 2;
            transform.Translate(Vector3.forward * sizeX);

        }
    }
    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.Equals(parentObject))
        {
            transform.Translate(Vector3.forward * (sizeY-sizeX));
        }

    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.Equals(parentObject))
        {
            isColliding = false;
        }
    }
}
