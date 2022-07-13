using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCast : MonoBehaviour
{

    public Transform PointAMina;
    public Transform PointBMina;
    public LayerMask Enemy;
    //public GameObject Enemigo;


    void Start()
    {
               
    }

    
    void Update()
    {
        RaycastHit hit = new RaycastHit();

        if (Physics.Linecast(PointAMina.position, PointBMina.position, out hit, Enemy))
        {
            print("Detectado");
            //Destroy(Enemigo.gameObject);
            Destroy(hit.collider.gameObject);

        }
        Debug.DrawLine(PointAMina.position, PointBMina.position, Color.red);
    }
}
