using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;// Required when using Event data.

public class SelectButtonHandler : MonoBehaviour, ISelectHandler// required interface when using the OnSelect method.
{
    GameObject canvas;

    public void Start()
    {
        canvas = GameObject.FindGameObjectWithTag("gui");
     }

    //Do this when the selectable UI object is selected.
    public void OnSelect(BaseEventData eventData)
    {

       // canvas.GetComponent<GUImanager>().SetColor();
    }

    //TODO: onclick (active?)
}