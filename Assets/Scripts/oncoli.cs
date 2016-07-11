using UnityEngine;
using System.Collections;

public class oncoli : MonoBehaviour {

    void OnCollisionEnter(Collision coli)
    {
        GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
}
