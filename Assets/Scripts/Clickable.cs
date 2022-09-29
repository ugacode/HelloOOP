using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickable : MonoBehaviour
{
    protected string ClickName = "Clickable";

    protected void DetectClicks()
    {
        if ( Input.GetMouseButtonDown (0))
        { 
            // ...
            RaycastHit hit; 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); 
            if ( Physics.Raycast (ray,out hit,100.0f))
            {
                if (hit.collider != null)
                {
                    if (hit.collider.gameObject == gameObject)
                    {
                        Debug.Log("Clicked on " + ClickName);
                    }
                }
                else
                {
                    Debug.Log("no collider");
                }
            }
            else
            {
                Debug.Log("no hit.");
            }
        }
    }
}
