using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActionController : MonoBehaviour
{

    public UnityAction TestEventAction;

    void Start()
    {
        
    }

    public void OnEnable()
    {
        TestEventAction = ShowAction;
        TestEventAction += SetSmallPrimitive;
        TestEventAction += ActivatePrimitive;
    }

    public void ShowAction()
    {
        
    }

    public void SetSmallPrimitive()
    {

    }

    public void ActivatePrimitive()
    {

    }
    void Update()
    {
        
    }
}
