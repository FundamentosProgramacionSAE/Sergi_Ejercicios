using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportSphere : MonoBehaviour
{

    public GameObject SphereTP;
    public GameObject CubeMov;
    public Vector3 Target;
    public float speed;
    public Vector3 GoTo;
    public Vector3 ReturnTo;
    public bool IsReturning;



    void Start()
    {        
        GoTo = new Vector3(3 + CubeMov.transform.position.x, CubeMov.transform.position.y, CubeMov.transform.position.z);
        ReturnTo = CubeMov.transform.position;
        Target = GoTo;
    }


    void Update()
    {
        float step = speed * Time.deltaTime; // calculate distance to move
        CubeMov.transform.position = Vector3.MoveTowards(CubeMov.transform.position, Target, step);

        if (Vector3.Distance(CubeMov.transform.position, Target) <= 0.001f && IsReturning == true)
        {
            // Swap the position of the cylinder.
            Target = GoTo;
            IsReturning = false;           
        }

        if (Vector3.Distance(CubeMov.transform.position, Target) <= 0.001f && IsReturning == false)
        {
            // Swap the position of the cylinder.
            Target = ReturnTo;
            IsReturning = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = SphereTP.transform.position;
        }
    }
}
