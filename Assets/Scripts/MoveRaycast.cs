using UnityEngine;
using System.Collections;

public class MoveRaycast : MonoBehaviour
{

    float v = Input.GetAxisRaw("Vertical");
    float h = Input.GetAxisRaw("Horizontal");


    public static void MoveObject(GameObject target, float moveSpeed = 20.0f, float minDistanceBetween = 60.0f)
    {

        Vector3 camera = Camera.main.transform.position;
        float distance = Vector3.Distance(new Vector3(camera.x, 0, camera.z), new Vector3(target.transform.position.x, 0, target.transform.position.z));

        if (Input.GetKey(KeyCode.W))
        {
            //TODO tu tez dodac sile
            //target.GetComponent<Rigidbody>().MovePosition(Vector3.MoveTowards(target.transform.position, new Vector3(camera.x, target.transform.position.y, camera.z), -moveSpeed));
            Vector3 dir;
            dir = Camera.main.transform.up;
            dir.y = 0;
            dir.Normalize();
            Vector3 ver = target.transform.InverseTransformDirection(dir);
            target.GetComponent<Rigidbody>().AddRelativeForce(ver * moveSpeed, ForceMode.Impulse);

        }
        else if (Input.GetKey(KeyCode.S))
        {
            if (distance > minDistanceBetween)
            {
                // target.GetComponent<Rigidbody>().MovePosition(Vector3.MoveTowards(target.transform.position, new Vector3(camera.x, target.transform.position.y, camera.z), moveSpeed));
                Vector3 dir;
                dir = Camera.main.transform.up;
                dir.y = 0;
                dir.Normalize();
                Vector3 ver = target.transform.InverseTransformDirection(dir);
                target.GetComponent<Rigidbody>().AddRelativeForce(ver * -moveSpeed, ForceMode.VelocityChange);
            }
        }


        if (Input.GetKey(KeyCode.A))
        {
            Vector3 dir;
            dir = Camera.main.transform.right;
            dir.y = 0;
            dir.Normalize();
            Vector3 ver =   target.transform.InverseTransformDirection(dir);
            //target.transform.Translate(ver * -moveSpeed);
            target.GetComponent<Rigidbody>().AddRelativeForce(ver * -moveSpeed,ForceMode.VelocityChange);
        }
       else if (Input.GetKey(KeyCode.D))
        {
            Vector3 dir;
            dir = Camera.main.transform.right;
            dir.y = 0;
            dir.Normalize();
            Vector3 ver = target.transform.InverseTransformDirection(dir);
            // target.transform.Translate(ver * moveSpeed);
            target.GetComponent<Rigidbody>().AddRelativeForce(ver * moveSpeed, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.Q))
        {
           // target.GetComponent<Rigidbody>().AddRelativeTorque(Vector3.up * moveSpeed, ForceMode.VelocityChange);
            target.transform.Rotate(Vector3.up * moveSpeed/5);
        }
        else if (Input.GetKey(KeyCode.E))
        {
            // target.GetComponent<Rigidbody>().AddRelativeTorque(Vector3.up * -moveSpeed, ForceMode.VelocityChange);
            target.transform.Rotate(Vector3.up * -moveSpeed/5);
        }

    }



    //todo stopowa item na keyup
}
