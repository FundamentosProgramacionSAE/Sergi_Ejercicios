using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeController : MonoBehaviour
{
   
    void Start()
    {
        
    }
    public void AñadirUpgrades()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            AttackController.MyDelegateAttack += Quemar;
            AttackController.MyDelegateAttack -= Ahogar;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            AttackController.MyDelegateAttack -= Quemar;
            AttackController.MyDelegateAttack += Ahogar;
        }
            
    }
    public void ChangeColor()
    {

    }

    public void Quemar()
    {
        print("Quemado Chuchoooo!!");
    }

    public void Ahogar()
    {
        print("Ahogate perroooo!!!");
    }
    void Update()
    {       
       AñadirUpgrades();       
    }
}
