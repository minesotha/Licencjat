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
	void FixedUpdate () {
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
            this.enabled = false;
            Debug.Log("self trigger enter");
            isColliding = true;
            sizeX= parentObject.GetComponent<Collider>().bounds.size.x/2 + 2;
            //sizeY = parentObject.GetComponent<Collider>().bounds.size.y/2 + 2;
            transform.Translate(Vector3.forward * sizeX/2);

        }
    }
    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.Equals(parentObject))
        {
            transform.Translate(Vector3.forward * 10);
        }

    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.Equals(parentObject))
        {
            isColliding = false;
        }
         this.enabled = true;
    }
    //public void SetColor()
    //{
    //    //test
    //    parentObject.GetComponentInChildren<Renderer>().material.color = Color.cyan;
    //}
}
