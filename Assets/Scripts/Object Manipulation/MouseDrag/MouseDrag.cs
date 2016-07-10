using UnityEngine;
using System.Collections;


public class MouseDrag : MonoBehaviour
{
    private int normalCollisionCount = 1;
    public float moveLimit = 10f;
    public float collisionMoveFactor = 0.01f;
    public bool freezeRotationOnDrag = true;
    Camera cam;
    private Rigidbody myRigidbody;
    private Transform myTransform;
    private bool canMove = false;
    private float yPos;
    public bool gravitySetting = false;
    private bool freezeRotationSetting;
    private float sqrMoveLimit;
    private int collisionCount = 0;
    public Transform camTransform;

   // public Canvas canvas;


    // Use this for initialization
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        myTransform = transform;
        if (!cam)
        {
            cam = Camera.main;
        }
        if (!cam)
        {
            Debug.LogError("Can't find camera tagged MainCamera");
            return;
        }
        camTransform = cam.transform;
        sqrMoveLimit = moveLimit * moveLimit;	// Since we're using sqrMagnitude, which is faster than magnitude

    }

    void OnMouseOver()
    {

        if (Input.GetMouseButtonDown(6))
        {
            Debug.Log("gfsgdgsd");
            onMouse3Click();
        }
       
    }


    void onMouse3Click()
    {
    
        GetComponent<ChooseFurnitureGUI>().setGui();
    }


    void OnMouseDown()
    {
        myRigidbody.isKinematic = false;
        canMove = true;
        gravitySetting = myRigidbody.useGravity;
        freezeRotationSetting = myRigidbody.freezeRotation;
        myRigidbody.useGravity = gravitySetting;
        myRigidbody.freezeRotation = freezeRotationOnDrag;
        yPos = myTransform.position.y;
    }

    void OnMouseUp()
    {
        myRigidbody.isKinematic = true;
        canMove = false;
        myRigidbody.useGravity = gravitySetting;
        myRigidbody.freezeRotation = freezeRotationSetting;
        if (!myRigidbody.useGravity)
        {
            myTransform.position = new Vector3(myTransform.position.x, yPos, myTransform.position.z);
        }
    }

    void OnCollisionEnter()
    {
        
        collisionCount++;
    }

    void OnCollisionExit()
    {
        collisionCount--;
    }

    void FixedUpdate()
    {
        if (!canMove) return;

        myRigidbody.velocity = Vector3.zero;
        myRigidbody.angularVelocity = Vector3.zero;
        myTransform.position = new Vector3(myTransform.position.x, yPos, myTransform.position.z);
        var mousePos = Input.mousePosition;
        var move = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, camTransform.position.y - myTransform.position.y)) - myTransform.position;
        move.y = 0.0f;
      //  if (collisionCount > normalCollisionCount)
      //  {
        //   move = move.normalized * collisionMoveFactor;
      //  }
       if (move.sqrMagnitude > sqrMoveLimit)
        {
            move = move.normalized * moveLimit;
       }

        myRigidbody.MovePosition(myRigidbody.position + move);
    }
}
