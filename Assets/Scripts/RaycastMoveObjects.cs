using UnityEngine;
using System.Collections;

public class RaycastMoveObjects : MonoBehaviour {
    public float seeDistance = 10.0f;
    Light lastLigh = null;
    GameObject currTarget = null;
    GameObject lastDrag = null;
    //czy jest cos przeciagane?
    bool doLookUp = true;
    UnityEngine.UI.Button lastBtn;


    public void SetColor()
    {
        //TODO: not last light, but canvas target 
        foreach (Transform child in lastLigh.transform)
        {
            if (child.tag == "colorable")
            {
                child.gameObject.GetComponent<Renderer>().material.color = lastBtn.GetComponent<UnityEngine.UI.Image>().color;
            }
        }
    }
    



    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space) && lastLigh != null)
        {
            lastLigh.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            MoveRaycast.MoveObject(lastLigh.gameObject);
            lastDrag = lastLigh.gameObject;
            doLookUp = false;
            lastBtn = null;

        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            lastDrag.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            doLookUp = true;
        }

      



        if (doLookUp == true)
        {
            Vector3 fwd = transform.TransformDirection(Vector3.forward);
            RaycastHit hit;

            if (Physics.Raycast(transform.position, fwd, out hit, seeDistance))
            {
                if (hit.transform.gameObject != currTarget)
                {
                    currTarget = transform.gameObject;



                    if (lastLigh != null && lastLigh != currTarget.GetComponent<Light>())
                    {
                        lastLigh.enabled = false;

                    }
                    Debug.Log("Widzę: " + hit.collider.gameObject.name);
                    if (lastBtn != null && lastBtn != hit.collider.gameObject.GetComponent<UnityEngine.UI.Button>())
                    {
                        lastBtn.Select();
                        lastBtn.GetComponent<UnityEngine.UI.Image>().CrossFadeAlpha(0.2f, 0.2f, false);
                        lastBtn = null;
                    }

                    if (hit.collider.gameObject.tag.Equals("colorButton"))
                    {

                        lastBtn = hit.collider.gameObject.GetComponent<UnityEngine.UI.Button>();
                        lastBtn.GetComponent<UnityEngine.UI.Image>().CrossFadeAlpha(1000, 20, false);
                        //btn.Select();
                        if (Input.GetMouseButtonDown(0))
                        {

                            SetColor();

                        }
                    }

                    if (hit.collider.gameObject.GetComponent<Light>() != null)
                    {

                        lastLigh = hit.collider.gameObject.GetComponent<Light>();
                        lastLigh.enabled = true;


                        if (Input.GetMouseButtonDown(0))
                        {
                            if (lastLigh != null)
                            {
                                lastLigh.gameObject.GetComponent<ChooseFurnitureGUI>().setGui();
                            }
                        }
                    }
                }
            }
        }
    }
}
