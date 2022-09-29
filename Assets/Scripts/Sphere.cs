using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : ClickableList
{
    // Start is called before the first frame update
    void Start()
    {
        ClickName = "Sphere";
    }

    // Update is called once per frame
    void Update()
    {
        base.DetectClicks();
    }
}
