using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackController : MonoBehaviour
{
    public delegate void DelegateAttack();
    public static DelegateAttack MyDelegateAttack;

    void Start()
    {
        MyDelegateAttack += BasicAttack;
    }

    public void Attack()
    {
        if (MyDelegateAttack != null)
        {
            MyDelegateAttack();
        }
    }

    public void BasicAttack()
    {
        print("Ataque basicooo!!!");
    }

    
    void Update()
    {
        
    }
}
