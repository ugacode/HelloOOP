using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public GameObject button;
    public Light lightSource;

    private bool turnedOn = true;
    void OnMouseDown()
    {
        if (lightSource != null)
        {
            if (turnedOn)
            {
                Debug.Log("Turning lights off");
                lightSource.intensity = 0.0f;
                button.transform.position -= new Vector3(0,0,0.1f);
                turnedOn = false;
            }
            else
            {
                Debug.Log("Turning lights on");
                lightSource.intensity = 1.0f;
                button.transform.position += new Vector3(0,0,0.1f);
                turnedOn = true;
            }
        }
    }
}
