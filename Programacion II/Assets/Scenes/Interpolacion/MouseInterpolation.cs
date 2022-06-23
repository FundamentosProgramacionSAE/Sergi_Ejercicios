using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInterpolation : MonoBehaviour
{

    public GameObject Image;

    public Vector2 UltimaPosicion;

    void Start()
    {
        
    }

    
    void Update()
    {
        UltimaPosicion = Vector2.Lerp(Input.mousePosition, UltimaPosicion, 0.9f);
        Image.transform.position = UltimaPosicion; 

    }
}
