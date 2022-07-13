using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointRayExample : MonoBehaviour
{

    public int m_RayLength = 100;

    Ray _mouseRay;
    RaycastHit _hit;


    void Start()
    {
        
    }

   
    void Update()
    {
        _mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(_mouseRay, out _hit, m_RayLength))
        {
            Debug.DrawLine(_mouseRay.origin, _hit.point, Color.red);
        }
        else
        {
            Debug.DrawLine(_mouseRay.origin, _mouseRay.direction * m_RayLength, Color.blue);
        }
    }
}
