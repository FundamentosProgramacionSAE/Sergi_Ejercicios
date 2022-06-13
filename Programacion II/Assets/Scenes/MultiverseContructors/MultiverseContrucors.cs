using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiverseContrucors : MonoBehaviour
{
    Hero _hero1;
    Hero _hero2;
    void Start()
    {
        _hero1 = new Hero("Gerard", 26, 0);
        print ("Stats: "  +  _hero1.Edad  + " " +  _hero1.NombreHero  + " " +   _hero1.Poderes);
        _hero2 = new Hero("Nicklas", 89, 0.1f);
        print("Stats: " + _hero2.Edad + " " + _hero2.NombreHero + " " + _hero2.Poderes);
    }
    
    void Update()
    {
        
    }
}
