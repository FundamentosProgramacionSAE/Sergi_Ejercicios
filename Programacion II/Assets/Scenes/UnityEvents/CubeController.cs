using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public GameObject Cube;
    void Start()
    {
        
    }
    public void ChangeScale()
    {
        Vector3 ScaleCube = new Vector3(0.5f, .5f, 0.5f);
        Cube.transform.localScale = ScaleCube;
    }
    
    void Update()
    {
        
    }
}
