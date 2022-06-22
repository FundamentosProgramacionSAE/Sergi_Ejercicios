using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeInterpolation : MonoBehaviour
{
    public float Counter = 0;
    public float AllTime;
    public float _transition;
    public bool IsFunction = true;

    public GameObject Sphere;
    public GameObject Cube;
    void Start()
    {
        
    }

    public void TimePaso()
    {
        _transition = Counter / AllTime;
        if (IsFunction == true)
        {
            
            float newScaleSphere = Mathf.Lerp(1, 3, _transition);
            Sphere.transform.localScale = new Vector3(newScaleSphere, newScaleSphere, newScaleSphere);
            Counter = Counter + Time.deltaTime;
            if (Counter > 5f)
            {
                Counter = 0f;
            }
        }
        else
        {            
            float newPositionSphere = Mathf.Lerp(0, 3, _transition);
            Sphere.transform.position = new Vector3(newPositionSphere, newPositionSphere, newPositionSphere);
            Counter = Counter + Time.deltaTime;
            if (Counter > 5f)
            {
                Counter = 0f;
            }
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            IsFunction = true;
        }    
        
        if (Input.GetKeyDown(KeyCode.D))
        {
            IsFunction = false;
        }
    }
     
    
    void Update()
    {        
        TimePaso();        
    }
}
