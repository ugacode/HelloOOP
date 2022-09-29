using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : ClickableList
{
    // Start is called before the first frame update
    void Start()
    {
        ClickName = "Cube";
    }

    // Update is called once per frame
    void Update()
    {
        base.DetectClicks();
    }
}
