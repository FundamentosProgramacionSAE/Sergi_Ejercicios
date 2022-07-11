using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCast : MonoBehaviour
{

    public Transform PointAMina;
    public Transform PointBMina;
    public LayerMask Enemy;
    public GameObject Enemigo;


    void Start()
    {
               
    }

    
    void Update()
    {
        if (Physics.Linecast(PointAMina.position, PointBMina.position, Enemy))
        {
            print("Detectado");
            Destroy(Enemigo.gameObject);

        }
        Debug.DrawLine(PointAMina.position, PointBMina.position, Color.red);
    }
}
