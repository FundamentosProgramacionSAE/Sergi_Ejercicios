using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderInterpolador : MonoBehaviour
{

    public GameObject Sphere;
    public GameObject Cube;

    void Start()
    {
     
    }

    public void HacerPaso (float _paso)
    {
        float newPositionSphere = Mathf.Lerp(-3, 3, _paso);
        Sphere.transform.position = new Vector3(newPositionSphere, Sphere.transform.position.y, Sphere.transform.position.z);
        float newScaleSphere = Mathf.Lerp(1, 3, _paso);
        Sphere.transform.localScale = new Vector3(newScaleSphere, newScaleSphere, newScaleSphere);

        float newPositionCube = Mathf.SmoothStep(-3, 3, _paso);
        Cube.transform.position = new Vector3(newPositionCube, Cube.transform.position.y, Cube.transform.position.z);
        float newScaleCube = Mathf.Lerp(2, 0.3f, _paso);
        Cube.transform.localScale = new Vector3(newScaleCube, newScaleCube, newScaleCube);
    }

    
    void Update()
    {
        
    }
}
