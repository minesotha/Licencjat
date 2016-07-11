using UnityEngine;
using System.Collections;

public class MoveRaycast : MonoBehaviour
{

    float v = Input.GetAxisRaw("Vertical");
    float h = Input.GetAxisRaw("Horizontal");

    public static void MoveObject(GameObject target, float moveSpeed = 10.0f)
    {
       Vector3 camera =  Camera.main.transform.position;


        if (Input.GetKey(KeyCode.W))
        {
            // target.transform.Translate(Vector3.forward * moveSpeed);

             target.transform.position = Vector3.MoveTowards(target.transform.position, new Vector3(-camera.x, target.transform.position.y, -camera.z), moveSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
              //target.transform.Translate(Vector3.back * moveSpeed);
            target.transform.position = Vector3.MoveTowards(target.transform.position, new Vector3(camera.x, target.transform.position.y, camera.z), moveSpeed);



         }
            if (Input.GetKey(KeyCode.A))
            {
                target.transform.Translate(Vector3.left * moveSpeed);
            }
            if (Input.GetKey(KeyCode.D))
            {
                target.transform.Translate(Vector3.right * moveSpeed);
            }
        target.GetComponent<Rigidbody>().MovePosition(target.transform.position);


    }




}
