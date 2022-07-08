using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Array : MonoBehaviour
{

    public int[] NumEnteros;
    public int[] NumEnterosInvertido;
    

    void Start()
    {
        NumEnterosInvertido = new int[5];

        for (int i = 0; i < NumEnteros.Length; i++)
        {
            print(NumEnteros[i]);
        }        
        
        for (int i = 0; i < NumEnterosInvertido.Length; i++)
        {
            NumEnterosInvertido[i] = NumEnteros[NumEnteros.Length -1 - i]; 
        }
        //print(NumEnterosInvertido[0]);
    }

    
    void Update()
    {
        
    }
}
