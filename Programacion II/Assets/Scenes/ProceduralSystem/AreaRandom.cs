using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaRandom : MonoBehaviour
{

    public GameObject Cubo1;
    public GameObject Cubo2;

    public GameObject SpherePrefab;

    void Start()
    {
        
    }

    public void RandomAreaCubo1()
    {
        float xLimits = Cubo1.transform.localScale.x / 2f;
        float xPos = Random.Range (-xLimits, xLimits);

        float yLimits = Cubo1.transform.localScale.y / 2f;
        float yPos = Random.Range(-yLimits, yLimits);

        float zLimits = Cubo1.transform.localScale.z / 2f;
        float zPos = Random.Range(-zLimits, zLimits);

        Vector3 PosSphere = Cubo1.transform.position +  new Vector3(xPos, yPos, zPos);

        Instantiate(SpherePrefab, PosSphere, transform.rotation);        
    }

    public void RandomAreaCubo2()
    {
        float xLimits = Cubo2.transform.localScale.x / 2f;
        float xPos = Random.Range(-xLimits, xLimits);

        float yLimits = Cubo2.transform.localScale.y / 2f;
        float yPos = Random.Range(-yLimits, yLimits);

        float zLimits = Cubo2.transform.localScale.z / 2f;
        float zPos = Random.Range(-zLimits, zLimits);

        Vector3 PosSphere = Cubo2.transform.position +  new Vector3(xPos, yPos, zPos);

        Instantiate(SpherePrefab, PosSphere, transform.rotation);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RandomAreaCubo1();
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            RandomAreaCubo2();
        }
    }
}
