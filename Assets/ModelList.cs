using UnityEngine;
using System.Collections;

public class ModelList : MonoBehaviour {
    //drag prefab here in editor
    public Transform model1;
    public Transform model2;
    public Transform model3;
    public Transform model4;

    public Transform getModel(string name)
    {
        if (name == "krzeslo2")
        {
            return model1;
        }
        else if (name == "krzeslo3")
        {
            return model2;
        }
        else if (name == "krzeslo4")
        {
            return model3;
        }
        else if (name == "krzeslo5")
        {
            return model4;
        }
        return model1;
    }


}
