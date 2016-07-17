using UnityEngine;
using System.Collections;

public class MovingWithMouse : MonoBehaviour {
    public float speedH = 2.0f;
    public float speedV = 2.0f;

    public float moveSpeed = 10.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;




    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void FixedUpdate () {

        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

        //chowanie kursora
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Cursor.visible = !Cursor.visible;
        }


        if (Input.GetKey(KeyCode.Space))
        {
            //spacja zarezerowana do przesuwania obiektow
        }
        else { 

            if (Input.GetKey(KeyCode.W))
            {
             
                transform.Translate(Vector3.forward * moveSpeed);

            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.back * moveSpeed );
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.left * moveSpeed);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.right * moveSpeed );
            }
        }

    }




}
