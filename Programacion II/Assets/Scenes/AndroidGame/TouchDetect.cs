using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchDetect : MonoBehaviour
{



    void Start()
    {

    }

    
    void Update()
    {

        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                // Construct a ray from the current touch coordinates
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                if (Physics.Raycast(ray))
                {
                    Handheld.Vibrate();
                }
            }
        }

    }
}
