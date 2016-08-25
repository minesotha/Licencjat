using UnityEngine;

public class ChooseFurnitureGUI : MonoBehaviour {
    GameObject canvas;
    bool isSet;
    GameObject changeFurniturePanel;


    public void Start()
    {
        var manager = GameObject.FindGameObjectWithTag("manager").GetComponent<getGui>();
        canvas = manager.getFurnitureCanvas();
        isSet = false;
        changeFurniturePanel = GameObject.FindGameObjectWithTag("changeModelPanel");
        if (this.changeFurniturePanel != null) {
            changeFurniturePanel.SetActive(false);
        }
    }

    public void setGui()
    {

        if (isSet == false)
        {
            canvas.SetActive(true);
            canvas.transform.position = this.transform.position;
            float moveZ = gameObject.GetComponent<Collider>().bounds.size.z / 2 + 1;
            canvas.transform.LookAt(Camera.main.transform);
            canvas.transform.Translate(Vector3.forward * moveZ);
            canvas.GetComponent<GUImanager>().isStarting = true;
            canvas.GetComponent<GUImanager>().parentObject = this.gameObject;
            isSet = true;

            if (this.changeFurniturePanel != null)
            {

                if (canvas.GetComponent<GUImanager>().parentObject.GetComponent<ModelList>() != null)
                {
                    this.changeFurniturePanel.SetActive(true);

                }
                else
                {
                    this.changeFurniturePanel.SetActive(false);

                }
            }
        }
        else
        {
            canvas.SetActive(false);
            isSet = false;
        }
    }
    
    public void hideGui()
    {
        if(canvas!=null)
        {
            canvas.GetComponent<GUImanager>().parentObject = null;
            canvas.SetActive(false);
            if (this.changeFurniturePanel != null)
            {
             this.changeFurniturePanel.SetActive(false);
            }
        }

        isSet = false;
    }


}
