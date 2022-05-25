using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comportamiento : MonoBehaviour
{
    public Transform Cube;
    void Start()
    {
         
    }

    
    void Update()
    {
        Cube.Rotate(45f * Time.deltaTime , 10f * Time.deltaTime, 25f * Time.deltaTime);
        
    }
}
