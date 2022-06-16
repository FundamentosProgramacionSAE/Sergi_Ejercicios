using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventController : MonoBehaviour
{

    public UnityEvent TestUnityEvent;

    
    void Start()
    {
        TestUnityEvent.AddListener(ShowAction);
    }

    public void ShowAction()
    {
        print("Niklas no sabe programar");
    }


    void Update()
    {
        if (Input.anyKeyDown)
        {
            TestUnityEvent.Invoke();
        }
    }
}
