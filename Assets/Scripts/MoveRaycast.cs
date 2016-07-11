using UnityEngine;
using System.Collections;

public class MoveRaycast : MonoBehaviour
{

    public static void MoveObject(GameObject target, float moveSpeed = 10.0f)
    {


        if (Input.GetKey(KeyCode.W))
            {
                target.transform.Translate(Vector3.forward * moveSpeed);

            }
            if (Input.GetKey(KeyCode.S))
            {
                target.transform.Translate(Vector3.back * moveSpeed);
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
