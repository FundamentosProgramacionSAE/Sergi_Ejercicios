using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObtenerChuches : MonoBehaviour
{

    public Jarron Jarron;
    
    void Start()
    {
        print(Jarron.ChuchesValue);
        Jarron.ChuchesValue = 5;
        print(Jarron.ChuchesValue);
    }

    
    void Update()
    {
        
    }
}
