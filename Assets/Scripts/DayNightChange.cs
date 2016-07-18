using UnityEngine;
using System.Collections;

public class DayNightChange : MonoBehaviour {
    private GameObject[] day;
    private GameObject[] night;
    bool isDay;
    
    void Start()
    {
        day = GameObject.FindGameObjectsWithTag("daylight");
         night = GameObject.FindGameObjectsWithTag("nightlight");

        foreach (GameObject light in day)
        {
            light.SetActive(true);
        }
        foreach (GameObject light in night)
        {
            light.SetActive(false);
        }
        isDay = true;

    }
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyUp(KeyCode.N)){
            if (isDay)
            {
                foreach(GameObject light in day)
                {
                    light.SetActive(false);
                }
                foreach (GameObject light in night)
                {
                    light.SetActive(true);
                }
                isDay = false;
            }
            else
            {
                foreach (GameObject light in day)
                {
                    light.SetActive(true);
                }
                foreach (GameObject light in night)
                {
                    light.SetActive(false);
                }
                isDay = true;
            }

        }
	
	}
}
