using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeysController : MonoBehaviour
{
    public delegate void EventPressKey();

    public static EventPressKey PressKeyEspada;
    public static EventPressKey PressKeyEscudo;
    void Start()
    {
        //PressKey += EspadaYEscudo;
        PressKeyEspada += DobleHacha; 
    }

    /*public void PressOnekey()
    {
        if (PressKey != null)
        {
            PressKey();
        }
    }*/
    public void EspadaYEscudo()
    {
        print("Ataque con espada y escudo");
    }
    public void DobleHacha()
    {
        print("Atacas con doble hacha");
    }
    public void APuñoLimpio()
    {
        print("Atacas con tus puños");
    }
    /*public void ChangeWeapons()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            KeysController.PressKey += DobleHacha;
            KeysController.PressKey -= EspadaYEscudo;
            KeysController.PressKey -= APuñoLimpio;
        }
        if (Input.GetKey(KeyCode.X))
        {
            KeysController.PressKey -= DobleHacha;
            KeysController.PressKey -= EspadaYEscudo;
            KeysController.PressKey += APuñoLimpio;
        }
    }*/

    void Update()
    {
       // ChangeWeapons();
        if (Input.GetKeyDown(KeyCode.C))
        {
            PressKeyEspada();
        }
       /* if (Input.GetKey(KeyCode.V))
        {
            PressKeyEscudo();
        }*/
       if (Input.GetKey(KeyCode.N))
       {
            PressKeyEspada = APuñoLimpio;
       }
        else
        {
            PressKeyEspada = DobleHacha;
        }
    }
}
