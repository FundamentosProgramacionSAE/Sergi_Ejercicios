using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RumbaRaycast : MonoBehaviour
{
    public float Speed;
    public LayerMask Wall;
    public float DistanceOnWall;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position += (transform.forward.normalized * Speed * Time.deltaTime);
        //transform.position.Normalize();

        print(transform.position.magnitude);



        if (Physics.Raycast(transform.position, gameObject.transform.forward, DistanceOnWall, Wall))
        {
            print("Detectado");

            transform.Rotate(0, 90f, 0, Space.Self);

        }
        Debug.DrawRay(transform.position, gameObject.transform.forward * DistanceOnWall, Color.red);
    }
}
