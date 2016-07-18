﻿using UnityEngine;

public class ChooseFurnitureGUI : MonoBehaviour {
    GameObject canvas;

    public void Start()
    {
        canvas = GameObject.FindGameObjectWithTag("gui");
    }

    public void setGui()
    {
        canvas.SetActive(true);
        canvas.transform.position = this.transform.position;
        float moveZ = gameObject.GetComponent<Collider>().bounds.size.z/2 + 1;
        // float moveY = gameObject.GetComponent<Collider>().bounds.size.y/2 + 1;
        //  float moveX = gameObject.GetComponent<Renderer>().bounds.size.x/2 + 1;
        //  canvas.transform.Translate(Vector3.up * moveY);
        //wysokosc kamery:
        canvas.transform.Translate(Vector3.up * Camera.main.transform.position.y);
        canvas.transform.LookAt(Camera.main.transform);
        canvas.transform.Translate(Vector3.forward * moveZ);
        canvas.GetComponent<GUImanager>().isStarting = true;
        canvas.GetComponent<GUImanager>().parentObject = this.gameObject;
    }
    
    void Update()
    {
     
    }

}
