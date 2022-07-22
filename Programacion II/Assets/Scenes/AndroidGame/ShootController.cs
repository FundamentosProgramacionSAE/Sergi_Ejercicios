using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootController : MonoBehaviour
{

    public GameObject PrefabProjectil;
    public GameObject Gun;
    //public float Speed;
    
    void Start()
    {
        
    }

    public void ShootProjectil()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(PrefabProjectil, Gun.transform.position, Gun.transform.rotation);
            print("Shoot");
        }

       
    }

    
    void Update()
    {
        ShootProjectil();
    }
}
