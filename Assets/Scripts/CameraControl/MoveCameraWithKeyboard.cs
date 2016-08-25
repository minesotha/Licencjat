using UnityEngine;
using System.Collections;

public class MoveCameraWithKeyboard : MonoBehaviour {
    public bool moveView = false;
    public float speedH = 2.0f;
    public float speedV = 2.0f;

    public float moveSpeed = 10.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;




    // Use this for initialization
    void Start() {
    }

    // Update is called once per frame
    void FixedUpdate() {
        if (moveView == true)
        {
            if (Input.GetJoystickNames().GetLength(0) < 1) {


                yaw += speedH * Input.GetAxis("Mouse X");
                pitch -= speedV * Input.GetAxis("Mouse Y");

                transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
            }
        }


        //chowanie kursora
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Cursor.visible = !Cursor.visible;
        }


        if (Input.GetKey(KeyCode.Space)||(Input.GetButton("Fire2")))
        {
            //spacja zarezerowana do przesuwania obiektow
        }
        else { 

            if (Input.GetAxis("Vertical")>0.5) //(Input.GetKey(KeyCode.W))
            {
                Vector3 newCameraPosition = transform.position + transform.forward * moveSpeed;
                transform.position = new Vector3(newCameraPosition.x, transform.position.y, newCameraPosition.z);
            }
            if (Input.GetAxis("Vertical") < -0.5)//(Input.GetKey(KeyCode.S))
            {
                Vector3 newCameraPosition = transform.position - transform.forward * moveSpeed;
                transform.position = new Vector3(newCameraPosition.x, transform.position.y, newCameraPosition.z);
            }
            if (Input.GetAxis("Horizontal") <- 0.5)//(Input.GetKey(KeyCode.A))
            {
                Vector3 newCameraPosition = transform.position - transform.right * moveSpeed;
                transform.position = new Vector3(newCameraPosition.x, transform.position.y, newCameraPosition.z);
            }
            if (Input.GetAxis("Horizontal") > 0.5) //(Input.GetKey(KeyCode.D))
            {
                Vector3 newCameraPosition = transform.position + transform.right * moveSpeed;
                transform.position = new Vector3(newCameraPosition.x, transform.position.y, newCameraPosition.z);
            }
        }

    }




}
