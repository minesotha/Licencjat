using UnityEngine;

public class ChooseFurnitureGUI : MonoBehaviour {
public Canvas canvas;


    public void setGui()
    {
       // canvas.gameObject.SetActive(true);
        canvas.transform.position = this.transform.position;
        float moveZ = gameObject.GetComponent<Renderer>().bounds.size.z/2 + 1;
       // float moveY = gameObject.GetComponent<Renderer>().bounds.size.y/2 + 1;
      //  float moveX = gameObject.GetComponent<Renderer>().bounds.size.x/2 + 1;
        canvas.transform.Translate(Vector3.up * moveZ);
        canvas.transform.LookAt(Camera.main.transform);
        canvas.transform.Translate(Vector3.forward * 3);
        canvas.GetComponent<GUImanager>().isStarting = true;
        canvas.GetComponent<GUImanager>().parentObject = this.gameObject;
    }
    
    void Update()
    {
     
    }

}
