using UnityEngine;
using System.Collections;

public class ChooseColor : MonoBehaviour {


    void ColorPreview()
    {
        GetComponent<Renderer>().material.color = Color.cyan;
    }

    void ChangeColor()
    {

    }

}
