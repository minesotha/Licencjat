#pragma strict

/*var cursorOnObject : boolean;
var selectedTransform : Transform;
cursorOnObject = false;
*/

function Start () 
{
}

function Update () 
{
}

function OnMouseOver() {
Rotation();
}

function Rotation() {
if (Input.GetKeyDown(KeyCode.LeftBracket))
{
transform.Rotate (transform.rotation.x,transform.rotation.y,transform.rotation.z + 45);
}

else if (Input.GetKeyDown(KeyCode.RightBracket)) 
{
transform.Rotate (transform.rotation.x,transform.rotation.y,transform.rotation.z - 45);
}
}