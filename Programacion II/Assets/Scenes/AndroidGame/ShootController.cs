using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootController : MonoBehaviour
{

    public GameObject PrefabProjectil;
    public GameObject Gun;
    public float Speed;
    
    void Start()
    {
        
    }

    public void ShootProjectil()
    {
        //Projectil = Instantiate(PrefabProjectil, Gun.transform.position, Quaternion.identity);
        print("Shoot");
    }

    
    void Update()
    {
        
    }
}
