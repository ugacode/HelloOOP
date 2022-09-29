using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableDictionary : MonoBehaviour
{
    protected string ClickName = "Clickable";
    protected static Dictionary<string, int> ClickedObjects = new Dictionary<string, int>();

    protected void DetectClicks()
    {
        if ( Input.GetMouseButtonDown (0))
        { 
            RaycastHit hit; 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); 
            if ( Physics.Raycast (ray,out hit,100.0f))
            {
                if (hit.collider != null)
                {
                    if (hit.collider.gameObject == gameObject)
                    {
                        Debug.Log("Clicked on " + ClickName);
                        if (ClickedObjects.ContainsKey(ClickName))
                        {
                            ClickedObjects[ClickName]++;
                        }
                        else
                        {
                            ClickedObjects[ClickName] = 1;
                        }
                    }
                }
                else
                {
                    Debug.Log("no collider");
                }
            }
            else
            {
                string previousHits = string.Empty;
                previousHits = string.Join(',',ClickedObjects);
                Debug.Log("no hit. previous hits are - " + previousHits);
            }
        }
    }
}
