using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jarron : MonoBehaviour
{
    private int _chuchesValue = 7;

    public int ChuchesValue 
    {
        get
        {
            return _chuchesValue;
        }
        set
        {
            _chuchesValue = value + 200;
        }

    }

    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
}
