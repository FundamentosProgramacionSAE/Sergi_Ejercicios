using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpAndSmoothStep : MonoBehaviour
{

    public Transform TR;

    public float firstPosition = 0f;
    public float lastPosition = 10f;
    public float transitionTime = 0.2f;

    void Start()
    {
        TR = GetComponent<Transform>();
        TR.position = Vector3.zero;
    }

    
    void Update()
    {
        float Value = Mathf.Lerp(firstPosition, lastPosition, transitionTime * Time.deltaTime);
        TR.transform.localScale = new Vector3(Value, Value, Value);
        firstPosition = Value;
    }
}
