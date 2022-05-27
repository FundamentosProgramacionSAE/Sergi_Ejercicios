using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comportamiento : MonoBehaviour
{
    
    public Animator CubeAnimator;
    public Animator SphereAnimator;
    public Animator CylinderAnimator;
    public GameObject Prefab;
    public Vector3 PuntoRespawn;
    void Start()
    {
         
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pelota"))
        {
            Destroy(other.gameObject);
            Instantiate(Prefab, PuntoRespawn, Quaternion.identity);
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            CubeAnimator.SetTrigger("TriggerAumentar");
        }           
        if (Input.GetKeyDown(KeyCode.X))
        {
            CubeAnimator.SetTrigger("TriggerDisminuir");
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            SphereAnimator.SetTrigger("MoveCurveUpTrigger");
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            SphereAnimator.SetTrigger("MoveCurveDownTrigger");
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            CubeAnimator.SetTrigger("TriggerChangeColourCube");
        }      
        if (Input.GetKeyDown(KeyCode.N))
        {
            SphereAnimator.SetTrigger("TriggerChangeColourSphere");
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            CylinderAnimator.SetTrigger("TriggerRotandMoveCylinder");
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            CylinderAnimator.SetTrigger("TriggerRotandMoveCylinderReverse");
        }



    }
}
