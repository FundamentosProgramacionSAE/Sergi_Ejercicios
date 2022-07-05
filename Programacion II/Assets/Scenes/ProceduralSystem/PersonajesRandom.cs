using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajesRandom : MonoBehaviour
{

    private System.Random generadorRandom = new System.Random();
    public enum RandomPersonajes
    {
        MonkeyDLuffy,
        SonGohan,
        MajinVegeta,
        Kakarot,
        PortgasDAce,
    }


    void Start()
    {
        Random.InitState(7);
        PrintRandomPersonajesAleatorio();
    }

    public void PrintRandomPersonajesAleatorio()
    {
        int _randomPersonajes = UnityEngine.Random.Range(0, 4);
        print((RandomPersonajes)_randomPersonajes);
    }

    public void PrintRandomPersonajesReal()
    {
        
        int _randomPersonajes = generadorRandom.Next(0, 4);
        print((RandomPersonajes)_randomPersonajes);
    }
    
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space))
        {
            PrintRandomPersonajesAleatorio();
        } 
    }
}
