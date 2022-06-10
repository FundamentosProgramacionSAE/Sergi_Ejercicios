using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NivelTorreta : MonoBehaviour
{
    private  int _nivel;
    public  int Nivel
    {
        get { return _nivel; } 
    }

    private void Awake()
    {
        _nivel = 80;
    }
    void Start()
    {
        PuntoDefensa.Attack();
    }

    

    
    void Update()
    {
        
    }
}
