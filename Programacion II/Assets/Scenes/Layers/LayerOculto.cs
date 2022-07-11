using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerOculto : MonoBehaviour
{

    public LayerMask NormalVision;
    public LayerMask GhostVision;

    void Start()
    {
        Camera.main.cullingMask = NormalVision;
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Camera.main.cullingMask = GhostVision;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Camera.main.cullingMask = NormalVision;
            
        }
    }
}
