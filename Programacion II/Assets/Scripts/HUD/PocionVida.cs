using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PocionVida : MonoBehaviour
{
    public HUDController Pepito;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Pepito.CambiarBarraVida(0.9f);
        }
    }
}
