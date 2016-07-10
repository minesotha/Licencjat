#pragma strict

 var speed = 1;
 var targetRadius = 1;
 private var target : Vector3;
  
 function Start () {
     GetComponent.<Rigidbody>().freezeRotation = true;
     target = transform.position;
     }
 
 /*function OnMouseUp () {
	transform.position.y = 0; //test purposes
	}
 */
  
 function FixedUpdate () {
 
     target.y = transform.position.y;
     if (Input.GetButton ("Fire1")) {
         var hit : RaycastHit; 
         var ray = Camera.main.ScreenPointToRay (Input.mousePosition);
         if (Physics.Raycast (ray, hit)) {
             target = hit.point;         
         }
         transform.localEulerAngles = new Vector3(270, 0, 0);
         transform.position.y = 0; // test purposes   
     }   
  
     if (Vector3.Distance(transform.position, target) > targetRadius) {
             transform.LookAt(target); 
             transform.Translate(0,0,speed); 
             transform.localEulerAngles = new Vector3(270, 0, 0);
             transform.position.y = 0; //test purposes
             }  
 }